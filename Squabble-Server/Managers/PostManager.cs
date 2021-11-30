using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Squabble.Data;
using Squabble.Interfaces;
using Squabble.Models.Entities;

namespace Squabble.Managers
{
    public class PostManager : IDataRepo<Post, int>
    {
        private readonly SquabbleContext _context;
        private readonly ILogger<PostManager> _logger;

        public PostManager(SquabbleContext context, ILogger<PostManager> logger)
        {
            _context = context;
            _logger = logger;
        }

        //returns posts... default implementation
        public IEnumerable<Post> GetAll()
        {
            return _context.Posts.ToList();
        }

        //return all posts that contain whatever the message is
        public IEnumerable<Post> Get(string content)
        {
            return _context.Posts.Where(x => x.Content.Contains(content)).ToList();
        }

        //returns post with id.. redundant, default method
        public Post Get(int id)
        {
            return _context.Posts.FirstOrDefault(x => x.PostId == id);

        }

        //add a post, return null if null post somehow sent here
        public async Task Add(Post post)
        {
            if (post == null)
            {
                _logger.LogError("Null post sent here.");
                return;
            }
            if (_context.Posts.Any(x => x.PostId == post.PostId))
            {
                _logger.LogError("Duplicate post sent here.");
                return;
            }
            try
            {
                await _context.Posts.AddAsync(post);
                await _context.SaveChangesAsync();
            } catch(Exception e)
            {
                _logger.LogError("Failed to add post to database.");
                _logger.LogError(e.Message);
                _logger.LogError(e.StackTrace);
            }
        }

        //throw request here, update and save then return the id
        public void Update(Post post)
        {
            if (post == null)
            {
                _logger.LogError("Null post sent here.");
                return;
            }
            if (!_context.Posts.Any(x => x.PostId == post.PostId))
            {
                _logger.LogError("Invalid post sent here.");
                return;
            }
            try
            {
                _context.Update(post);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError("Failed to update post in database.");
                _logger.LogError(e.Message);
                _logger.LogError(e.StackTrace);
            }
        }

        //delete a post
        public int Delete(int id)
        {
            if (!_context.Posts.Any(x => x.PostId == id)) { _logger.LogError("Invalid post sent here."); return -1; }
            try
            {
                _context.Posts.Remove(_context.Posts.Find(id));
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError("Failed to update post in database.");
                _logger.LogError(e.Message);
                _logger.LogError(e.StackTrace);
            }


            return id;
        }
        //get by id
        public Post GetById(int id)
        {
            return Get(id);
        }
    }
}
