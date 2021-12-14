using System;
using System.Threading.Tasks;
using Azure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Squabble.Helpers;
using Squabble.Interfaces;
using Squabble.Managers;

namespace Squabble.Controllers.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserTokenController : Controller
    {
        private ICommunicationTokenManager _acsManager { get; set; }
        private IAccountManager _accountManager { get; set; }

        public UserTokenController(ICommunicationTokenManager acsManager, IAccountManager accountManager)
        {
            _acsManager = acsManager;
            _accountManager = accountManager;
        }

        /// <summary>
        /// Create a User.
        /// </summary>
        /// <returns>The user id.</returns>
        [HttpGet]
        public async Task<IActionResult> GetUserAsync()
        {
            var user = await _acsManager.CreateUserAsync();
            try
            {
                var jsonFormattedUser = new
                {
                    communicationUserId = user.Id
                };

                return Ok(jsonFormattedUser);
            }
            catch (RequestFailedException ex)
            {
                Console.WriteLine($"Error occured while creation user: {ex}");
                return Ok(Json(ex));
            }
        }

        /// <summary>
        /// Create User and Generate token.
        /// </summary>
        /// <returns>The user id and token</returns>
        [HttpGet]
        public async Task<IActionResult> GetUserAndTokenAsync()
        {
            try
            {
                var (user, accessToken) = await _acsManager.CreateUserAndTokenAsync();

                var jsonFormattedUser = new
                {
                    communicationUserId = user.Id
                };

                var clientResponse = new
                {
                    user = jsonFormattedUser,
                    token = accessToken,
                    expiresOn = accessToken.ExpiresOn
                };

                return Ok(clientResponse);
            }
            catch (RequestFailedException ex)
            {
                Console.WriteLine($"Error occured while Generating Token: {ex}");

                return Ok(Json(ex));
            }
        }

        /// <summary>
        /// Refresh token for the specified user.
        /// </summary>
        /// <returns>The refreshed token.</returns>
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("{identity}")]
        public async Task<IActionResult> GetRefreshTokenAsync(string identity)
        {
            try
            {
                var response = await _acsManager.RefreshToken(identity);
                var clientResponse = new
                {
                    token = response.Token,
                    expiresOn = response.ExpiresOn
                };


                var id = SupportHelpers.FindIdFromToken(HttpContext.User.Claims);
                //Save new token in our own database
                var user = _accountManager.GetById(id);
                user.CommunicationToken = response.Token;
                ////TODO: add response check handling
                _accountManager.Update(user);
                //_accountManager.UpdateCommToken(id, response.Token);


                return Ok(clientResponse);
            }
            catch (RequestFailedException ex)
            {
                Console.WriteLine($"Error occured while Generating Token: {ex}");
                return Ok(Json(ex));
            }
        }
    }
}
