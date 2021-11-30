commit 02b1063241a9d9ba8c941c20900ade4c57dc7d4a
Author: S3807720 <51018322+S3807720@users.noreply.github.com>
Date:   Sun Nov 28 17:08:34 2021 +1100

    Update appsettings.json
    
    removed local DBs

commit 74e812dd3c9b4210388dcfa73128f05ce91a463a
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 26 16:00:32 2021 +0000

    Fix some outdated Azure seed data and add in a Migrations init script

commit 95e050be440b175da45c77ba76fbf2f0fa01b97b
Merge: 6e9a553 0e409f5
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 26 16:17:47 2021 +0100

    Merge pull request #45 from RMIT-COSC2650-SP3-2021-Team-3/random-code-clean
    
    Code clean as much as possible (no logic change just reformat/refactor)

commit 6e9a5538bc67d92a08e27a05b6ace0cc744409f8
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 26 15:16:51 2021 +0000

    Update README with database init and seeding data steps

commit 0e409f50509e93a371f6cf06087792183067f01c
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 25 16:06:44 2021 +0000

    Code clean as much as possible (no logic change just reformat/refactor)

commit 309f1d7893d39bccdd99e630aab702223a09f18c
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 25 15:45:46 2021 +0000

    Remove unused files from when the Web UI was included

commit 6ec2d3b4dce5460c75a5135cfe605c80c86139b9
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 25 15:21:59 2021 +0000

    Show error to user when resetting password from SSO account

commit c8c2b1507a4d664bdb6904d9c7d6684f92ccc97a
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 25 13:15:31 2021 +0000

    Remove unused NuGet dependencies

commit 0bfcdac7dd6c513c49a4c0136bdb3fa32cd8a639
Merge: a6a5b44 5208b04
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 25 13:34:16 2021 +0100

    Merge pull request #43 from RMIT-COSC2650-SP3-2021-Team-3/remove-user-from-server
    
    Remove user from server

commit 5208b046b0f6f1f9216c3b97e4334642150ba8ea
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 25 11:23:29 2021 +0000

    Remove leftover logging

commit 93b738d6220a6f84cb22a85a59ac068bb4ab788f
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Wed Nov 24 22:21:49 2021 +0000

    Fix old seeded Azure thread ID

commit 77e5f2c6c9f1951fd45b2abbb5b247d4a35bb037
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Wed Nov 24 22:21:36 2021 +0000

    Add support to remove user from server

commit a6a5b448657b2b17e8a9d5a3bc3a717b4e36d82a
Merge: 4439ec9 1004a41
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 25 13:31:20 2021 +0100

    Merge pull request #44 from RMIT-COSC2650-SP3-2021-Team-3/only-owner-can-call-bugfix
    
    Only owner can call bugfix

commit 1004a41fcdcf856c570c4fa9106a9f83103cbc5e
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 25 12:31:09 2021 +0000

    .gitignore internal-nlog.txt

commit 970694580a8d5cf95bb172ef898c1b1f7458638e
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 25 12:30:32 2021 +0000

    Refactor `GetMemberAcsIds` to be a little more efficient with less loops

commit 63e05c54f332137af65119d549ef87eb34ffc7c0
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 25 18:19:18 2021 +1100

    Added return of owner and admin accounts

commit c31d5c40b561a9258f7b4051a2e784984ca4fd97
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 25 18:18:34 2021 +1100

    Added return of owner and admin accounts

commit 4439ec958dba673a3337c6e961e9a1d62f9f7907
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Wed Nov 24 20:40:39 2021 +1100

    COMMENTS TO API

commit 936dcbf8ecb8eecbb978fe09e3d0ed9df01e8920
Merge: 6b73ade fc8abb1
Author: S3807720 <51018322+S3807720@users.noreply.github.com>
Date:   Wed Nov 24 11:03:07 2021 +1100

    Merge pull request #39 from RMIT-COSC2650-SP3-2021-Team-3/Logging-Error-Secure
    
    Logging error secure

commit fc8abb1e355b73f64b521d10079019a01feda0b7
Merge: ce1901b 6b73ade
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 24 10:46:47 2021 +1100

    Merge branch 'main' into Logging-Error-Secure

commit ce1901b28bd7f6e1ad17b5582465ee3f76f87a97
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Wed Nov 24 10:44:27 2021 +1100

    Channels - add member now returns a bad or ok request.
    Appsettings updated

commit 5757e4935adc5091b471f2b23a5c9a4f647d90af
Author: S3807720 <51018322+S3807720@users.noreply.github.com>
Date:   Tue Nov 23 22:41:12 2021 +1100

    Update ServerController.cs
    
    if (requestModel == null || string.IsNullOrEmpty(requestModel.Name)) { _logger.LogError("Null server sent here."); return; }
    
    Updated here as local isn't responding right now.

commit 6b73ade15111185db09fba4afea0702808ce5024
Merge: e049277 51069f3
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Nov 20 12:46:03 2021 +0100

    Merge pull request #41 from RMIT-COSC2650-SP3-2021-Team-3/conn-string
    
    Update Azure ACS and SQL connection strings

commit 51069f3c5f0e598f43087b9f184474a4aab44455
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Nov 20 11:45:26 2021 +0000

    Fix ACS tokens in seed data

commit 0614fe53410d1eed945ece8bf77e76c9242f6985
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Nov 20 11:07:23 2021 +0000

    Update connection strings

commit e0492778a0edd33394bf469cac6a36e29d0f26c4
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 18 13:41:55 2021 +0000

    Fix missing Azure Thread ID when seeding a channel

commit 72fa49731ab8f4d8b1f555f032ff58744aa8d5b7
Merge: fe6f006 5a41f53
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 18 13:28:15 2021 +0100

    Merge pull request #40 from RMIT-COSC2650-SP3-2021-Team-3/add-getChannelByThreadId-endpoint
    
    added an endpoint to get a channel by thread id

commit 5a41f539d5fc4c630ebf048235b4461d87a6bbe3
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Thu Nov 18 10:14:20 2021 +1100

    added an endpoint to get a channel by thread id

commit e0ed67ebd5ae307240ca7f52ad0adaf19eea0b97
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Wed Nov 17 22:19:08 2021 +1100

    Connection string fixed

commit 624443f2fe9c653315e18880f2b233fa33fd234c
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Wed Nov 17 22:18:42 2021 +1100

    All controllers and managers have error handling and logging. Nothing *should* crash the api.

commit f4c61c5829e6aaaa0ebf3a70674655b3b39d835c
Merge: 888fd50 8ed6dc2
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Tue Nov 16 23:02:30 2021 +1100

    Friend Request support added

commit 888fd50093f7cce2e4ac83cbbaf0e52223859393
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Tue Nov 16 23:00:28 2021 +1100

    Friend Requests & Controller support added for logging, error handling

commit 8ed6dc2466e2a07419f02af951981644b8cd6df6
Author: S3807720 <51018322+S3807720@users.noreply.github.com>
Date:   Tue Nov 16 13:40:12 2021 +1100

    Delete internal-nlog.txt
    
    waste of space

commit 0430449c9b8f29a9fd75d50dd82d45c2a9f90b4d
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Tue Nov 16 13:31:05 2021 +1100

    Account, Kanban, Login support added for error handling and catch.
    Logging support added using NLog. Only above 3 working at the moment.

commit fe6f006b9cbaed255948f62c662e2d46f5683ee5
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Nov 13 11:09:55 2021 +0000

    Add guides on deploying related Azure services

commit 70d3bb454dcab942d2537839d1f4beaaf119b6fd
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sat Nov 13 12:01:33 2021 +1100

    Fixed bug where channel owner was null

commit 17a5f57d157b9efded2be8eee55a1d88cd79fb78
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 16:50:48 2021 +0000

    Add a section in the README for coding conventions

commit f314beb6bfecc565d238a63feccc7a2f3f6e694f
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 16:48:34 2021 +0000

    Add spot to add unit testing information

commit 76c7090049c9de89ee094478c8b7a63ea7848326
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 16:43:09 2021 +0000

    Add README and related documentation (inc. licensing)

commit 84a0fbde62d3aac2ac28fcbd3a4ad46f3d6208bb
Merge: 18a41c4 6e55c10
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 14:23:56 2021 +0100

    Merge pull request #38 from RMIT-COSC2650-SP3-2021-Team-3/store-messages
    
    Refactor storing posts in DB and remove unused models and seed data

commit 6e55c102ade672d8dbfd038681bcfb349349b1e0
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 13:22:09 2021 +0000

    Refactor storing posts in DB and remove unused models and seed data

commit 18a41c4eb94c4882ea9059d0bf84fd03e8682c4d
Merge: 1a1b208 fe01bc5
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 13:33:10 2021 +0100

    Merge pull request #33 from RMIT-COSC2650-SP3-2021-Team-3/Kanban
    
    Kanban

commit fe01bc5a25db45dbe131f5ca976a2943b7a3cf03
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Wed Nov 10 17:53:12 2021 +1100

    More seed data for members / admin / owner

commit 4c80383adeee97e8ba9489c638bc22b188e32182
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Wed Nov 10 11:03:42 2021 +1100

    Spring cleaning - removing channel conversations.
    Fixed an async bug with kanban.

commit 347d32a2602ea3578eb76e5280346609006ca27b
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Tue Nov 9 22:18:05 2021 +1100

    added threadid to post

commit 746c7708cd9a12c6c6b3ee17ea0874b447857165
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Sun Nov 7 13:12:37 2021 +1100

    jwt authentication added

commit aa2f254c0f6c74c05e096e0f83325c0e5c8b88a1
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Sun Nov 7 12:59:24 2021 +1100

    Kanban support

commit 1a1b2085bf4e3ef206e376c8b85f3c0031a47b3b
Merge: 5d69a01 d52748d
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 10:58:32 2021 +0100

    Merge pull request #35 from RMIT-COSC2650-SP3-2021-Team-3/no-null-login
    
    Better handle bad login requests without required data

commit d52748da1ea9d201aba798ebe63cd3aa4677a889
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 09:57:58 2021 +0000

    Better handle bad login requests without required data

commit 5d69a0120e01bb7f1ca34dc3f4b4811579c4b2de
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 09:25:11 2021 +0000

    Add latest init DB migration scripts

commit 6c411716e0e3dfe092ac476a9fd3264132b2565e
Merge: d7e3753 80c1e81
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 10:22:08 2021 +0100

    Merge pull request #31 from RMIT-COSC2650-SP3-2021-Team-3/server-user-management
    
    Add API endpoints to support server user role management

commit 80c1e8185e8261a89d50d66a247a85113cb88fc7
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 08:51:15 2021 +0000

    Add API endpoints to support server user role management

commit d7e37535e438f4381da38d212f4cbed79c3acdea
Merge: f70d29f ed88d5c
Author: Duc Tran <55226475+s3500659@users.noreply.github.com>
Date:   Fri Nov 12 14:25:15 2021 +1100

    Merge pull request #37 from RMIT-COSC2650-SP3-2021-Team-3/fix-seed-user-comm-token
    
    Fix seeding user communication tokens

commit f70d29fe8f013d449e82e79300d3b3d8521fd184
Merge: 0f177f1 1aeb067
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 10:04:00 2021 +1100

    Merge pull request #34 from RMIT-COSC2650-SP3-2021-Team-3/contact-conversations
    
    Add support for accepting friend requests and having conversations

commit 1aeb067812707cb9a7dfcd313f14503f3b2e9272
Merge: 9cb2240 0f177f1
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 10:03:47 2021 +1100

    Merge branch 'main' into contact-conversations

commit 0f177f1be3b1b2cd395507dd124c5cffc66f57e3
Merge: 7212842 0b34d69
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 11 17:50:47 2021 +0100

    Merge pull request #36 from RMIT-COSC2650-SP3-2021-Team-3/channel-members-retrieval
    
    Channel members retrieval

commit ed88d5c17a08e32ad4b6841f791dcd10c18a106c
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 11 16:47:07 2021 +0000

    Fix seeding user communication tokens

commit 9cb224015119cb0e9cdac1305b20ba6da74d5d92
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 11 11:51:07 2021 +0000

    Add some seed data for a friendship conversation

commit 0b34d69a09f1856dd1e857a930ecb94a3bc00b89
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 11:33:56 2021 +1100

    Bugfix
    
    Admin role was not being flagged for admins

commit a916f776f4a8afcba54f31fa22e808d427485121
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 14:16:08 2021 +1100

    Added in a return property for member role

commit aea4ad4e8db9df04e5230adf56f363f6f2d47d26
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 14:15:43 2021 +1100

    Added in a return property for member role
    
    - Also returns the user's member info

commit 496b51b78762d14332d828acba155e5d08d34f0c
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 11:21:34 2021 +1100

    Added jwt auth to channel member info endpoint

commit 681a9d1c4c43d43f45f312991dcad437ddd0b593
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 11:15:55 2021 +1100

    Added endpoint for channel members dto list

commit bc4f0d9f7df09d38816f4da77805a8909a4ce67c
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 11:15:04 2021 +1100

    Added retrieval of channel members dto

commit 455a55bde01a5ba3d6763741c367a7afcbeedd74
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 11:13:53 2021 +1100

    Added channel member dto

commit f36a20a4a24c93e70c595b686d9eda0dbbb52ec5
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Nov 8 13:16:47 2021 +0000

    Add support for accepting friend requests and having conversations

commit 721284238e558d0d2542e7242ee37a7151d89c82
Merge: 13cf2e4 483dc25
Author: Duc Tran <55226475+s3500659@users.noreply.github.com>
Date:   Wed Nov 3 17:25:16 2021 +1100

    Merge pull request #32 from RMIT-COSC2650-SP3-2021-Team-3/get-user-by-communicationUserId
    
    add endpoint to get a user by communicationUserId

commit 483dc255184e2171a701a5c9017d05b66359f95d
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Wed Nov 3 16:53:50 2021 +1100

    add endpoint to get a user by communicationUserId

commit 13cf2e4c273830ca1c4f055920b65174351c4fca
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Wed Nov 3 11:06:02 2021 +1100

    Remove user API point added.
    Channel/RemoveUser - with the member as a body
    Server/RemoveUser now also removes all access to channels

commit 69eb90535435c351e9e976de3d5913f1526b3eda
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Nov 1 07:25:44 2021 +0000

    Fix broken `Server/GetChannels` endpoint

commit 3d8be5935352b3ef89ec273760fa5dc19a71df2f
Merge: c3b23af 3086427
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Sun Oct 31 19:52:55 2021 +1100

    Merge pull request #30 from RMIT-COSC2650-SP3-2021-Team-3/update-account-avatar
    
    added avatar string to request model

commit 3086427b9d6108f467ad636ba33e90479bd6098c
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Sun Oct 31 19:52:21 2021 +1100

    added avatartstring to request model

commit c3b23af7020d8777bbc055e3c85444b440b82c91
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Sun Oct 31 19:49:53 2021 +1100

    getservers(int id)

commit 040e8033b0012dbc6070e9b0a23ef9893fa3d1e5
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Oct 29 17:02:02 2021 +0100

    Fix broken server API paths

commit 9e2b63044ee7c60f77e042e4ba02b153492fb8ad
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Sat Oct 30 00:49:12 2021 +1100

    avatar support enabled

commit 9602c712b6eab91511de92713244591f9fdb01b2
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Thu Oct 28 19:49:06 2021 +1100

    names added to friendinfo

commit 8149e984698bd23e574b084a6bed622dca907c39
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Thu Oct 28 18:58:20 2021 +1100

commit e5a8474f59b8119aa76b5632ec3b01c70c89b71e
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Thu Oct 28 17:10:27 2021 +1100

    Friendship back to initial version

commit 462752d8b5b51709185375394696552b9d7830c9
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Thu Oct 28 16:47:52 2021 +1100

    Fixed someones fuck up. Don't throw statics in random places

commit 5b8229abfb2246a4d37ca9ba5c667f8864aeadb5
Merge: 4510160 c403a01
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Thu Oct 28 16:44:49 2021 +1100

    Merge branch 'main' of https://github.com/RMIT-COSC2650-SP3-2021-Team-3/Squabble-Server into main

commit 4510160b406e2c6746f6dcf67b6ee50f7ad23703
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Thu Oct 28 16:44:37 2021 +1100

    GetServers changed to rely on token.
    GetByEmail endpoint added

commit c403a019047f9dc23f74b39b04e67b6d70160c13
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Thu Oct 28 10:54:49 2021 +1100

    add interface for communicationTokenManager

commit 368b130ad0e73ddae3599bce66a125be92918100
Merge: 766cac3 5520dda
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Oct 26 11:33:11 2021 +1100

    Merge pull request #29 from RMIT-COSC2650-SP3-2021-Team-3/login-acsrefresh-responsebody-tweaks
    
    Tweaks

commit 5520dda1bf5feca865bd9bd57aa8fcab298fe60c
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Oct 25 14:05:54 2021 +1100

    Tweaks
    
    - Commented out refresh acs on login
    - Added untested fix for acs token account update
    - Added acs id and token to register/login response body

commit 766cac34db1920812565c4325ae77d9cd211fd4e
Merge: 4199da2 ee8996e
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Oct 25 09:52:14 2021 +1100

    Merge pull request #28 from RMIT-COSC2650-SP3-2021-Team-3/remove-site-code
    
    Removed redundant Website/UI code (inside wwwroot directory)

commit ee8996e7f0ebc76113ab5020451122bb21b0d149
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Oct 25 09:50:28 2021 +1100

    Removed redundant Website/UI code

commit 4199da24ac866a22e500c2f2846418ea3a1f8412
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Oct 23 10:13:46 2021 +0100

    More temp fixes for SSO registration

commit 35839c78908cfb689cae1c3d009d07d4231bd28d
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Oct 23 10:08:24 2021 +0100

    Temp fix for SSO registration

commit 61ec331fc0fa15572163b3b77d9b614b0309ba83
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Oct 23 09:20:43 2021 +0100

    Fix Microsoft SSO redirect path

commit 0aa489de82ab365d56bf0ad4aec49aa7fd1a4782
Merge: 1e3c95a 5abf3df
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sat Oct 23 16:30:53 2021 +1100

    Merge pull request #27 from RMIT-COSC2650-SP3-2021-Team-3/acs-refresh-bugfix
    
    Reimplemented acs refresh on login temporarily

commit 5abf3df693bf0b57685ffacaf0367a00fdc63020
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sat Oct 23 16:30:32 2021 +1100

    Reimplemented acs refresh on login temporarily

commit 1e3c95ad6b0f9f009b8596ff551efa4fd2f05cf8
Merge: d9fdc8c d31caf0
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sat Oct 23 13:40:52 2021 +1100

    Merge pull request #26 from RMIT-COSC2650-SP3-2021-Team-3/register-profile-bugfix
    
    Register json return now holds account id

commit d31caf0c97f84c00d8be08c818dfeecc12544de3
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sat Oct 23 13:40:08 2021 +1100

    Register json return now holds account id

commit d9fdc8cb897ac7c32219c427b099d1d9f8dd3e44
Merge: fecdd17 1f7fab7
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Oct 22 17:19:11 2021 +0200

    Merge pull request #22 from RMIT-COSC2650-SP3-2021-Team-3/team-chat-integration
    
    Team chat integration

commit 1f7fab7b7bb1bce6b9be6f8b443cc27b07fa7385
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Oct 22 16:18:56 2021 +0100

    [CI] Lower artefact retention days

commit 02ceafd4101fadf871c4c1ba74cb2846f368bdc8
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Oct 22 09:02:51 2021 +0100

    Server admin and owners can retrieve all channels

commit 5bf55a8dd677fd0ee635fe60e1f9bbb7ef431649
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Oct 22 08:56:15 2021 +0100

    Move `GetChannels` Server logic to the Manager

commit 9fa351d24295b529f6548cfd87981ebbb34f4ba1
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 21 16:55:18 2021 +0100

    When fetching channels for a server filter by user access

commit 49db7974b9da575ef4d6b7f7c4f1a2ebb720ca53
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 21 14:52:15 2021 +0100

    Support new ability to fetch and add new channels to a server

commit fecdd179ae950635a7613f711d8b91eefab7e24a
Merge: 4310ae7 525cb50
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 13:27:06 2021 +1100

    Merge pull request #25 from RMIT-COSC2650-SP3-2021-Team-3/redeploy
    
    Redeploy

commit 525cb50c7b7a2b7c5fe074a3d8377a49bcd8487f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 13:26:33 2021 +1100

    Made getting friends list asynchronous

commit 44e631c00ac71cc8cb0f1c2f72edb768009f0a19
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 13:25:44 2021 +1100

    Made getting friends list asynchronous

commit 4310ae796b40092ffe32ab54fa77569436653b23
Merge: f0b81a6 8a5e89e
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 13:03:00 2021 +1100

    Merge pull request #24 from RMIT-COSC2650-SP3-2021-Team-3/redeploy
    
    Update Startup.cs

commit 8a5e89e8255cf616f586f3fadf9052a3febb6a6b
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 13:02:36 2021 +1100

    Update Startup.cs

commit f0b81a6132df49eb55ca7ffbfb37c38ff4eeddd7
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 12:53:12 2021 +1100

    Update appsettings.json

commit 2c81e32e1f4f1ff47c1c948b0c53dce19cc0e92d
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 12:51:30 2021 +1100

    Add files via upload

commit 18a9cba547b8dccf0391ee49760b2e279df34a1a
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 12:51:14 2021 +1100

    Delete Migrations directory

commit eb52b941df6a911943acc93770a9c06c606f8da3
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 12:47:45 2021 +1100

    Update ServerController.cs

commit f90f6948be2c30f67d42505a31717322378a7f5d
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 12:40:56 2021 +1100

    Add files via upload

commit 825d0ff85c431e330d65935f3e8eb8c99a73c280
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 12:40:33 2021 +1100

    Delete SquabbleContextModelSnapshot.cs

commit 623ff829a7ab3881e4855819995b667e61679a2e
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 12:35:28 2021 +1100

    Add files via upload

commit cc3317fbc34b66fa95ea98a4b58c4b18c0a89e34
Merge: 95ce3ee 53b0d19
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 12:33:40 2021 +1100

    Merge pull request #20 from RMIT-COSC2650-SP3-2021-Team-3/friendship-acs-tweaks
    
    Miscellaneous tweaks

commit 53b0d19821517bd893c5529452751452ada5a172
Merge: 860be75 95ce3ee
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 12:27:57 2021 +1100

    Merge branch 'main' into friendship-acs-tweaks

commit 860be756c893baa5b7bbf358cddd57dfa7e105ab
Author: S3807720 <51018322+S3807720@users.noreply.github.com>
Date:   Fri Oct 22 12:24:59 2021 +1100

    Update ServerController.cs

commit 38b7350591ad8bf5e5d9976239e65103364a519b
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 12:07:33 2021 +1100

    Add files via upload

commit 1d024cd6fa781ebc91a576d57703d5839d58a7aa
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 12:07:16 2021 +1100

    Delete Migrations directory

commit 95ce3eefddf725a0dc5a87ba04ef239358f99779
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 11:59:50 2021 +1100

    Add files via upload

commit c7372a697b6efd626a7152b547fb519451686c3f
Merge: 9cb7fd3 4c131d1
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 11:57:14 2021 +1100

    Merge branch 'main' into friendship-acs-tweaks

commit 9cb7fd3bf0170d02828f510c22e85c2301c5525a
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 11:47:42 2021 +1100

    Add files via upload

commit c6f39a713d0c90108796e82fe7b47ef82bb0aee3
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 11:47:24 2021 +1100

    Added second friendship to spongebob

commit 4c131d19206ef6c794ab538dcfe42020af913ec1
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 21 17:32:50 2021 +0100

    Update initialise DB migration script

commit f85f4e1320eadd5a7c941cd586a7822a2d8a268f
Merge: bca63c1 10d295b
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 21 18:16:02 2021 +0200

    Merge pull request #23 from RMIT-COSC2650-SP3-2021-Team-3/security-questions
    
    Add support for security questions when resetting a password pre-auth

commit 10d295b2947c4f39b68ec5e9d2c7df91424f6a0d
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Oct 18 15:32:52 2021 +0100

    Add support for security questions when resetting a password pre-auth

commit bca63c1b0757a30f945c6597d8ac5fe9f14f53e1
Merge: bb5f9c3 d65a70f
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Thu Oct 21 22:05:58 2021 +1100

    Merge pull request #21 from RMIT-COSC2650-SP3-2021-Team-3/revert-18-security-questions
    
    Revert "Add support for security questions when resetting a password pre-auth"

commit d65a70f35da92377b9ee4bbc5fcc6cda676de18c
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Thu Oct 21 22:05:12 2021 +1100

    Revert "Add support for security questions when resetting a password pre-auth"

commit bb5f9c3804770b9e0cfc1cfa1e12a2cfe8f2cf43
Merge: 314145a a4a2b2a
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Thu Oct 21 21:37:46 2021 +1100

    Merge pull request #18 from RMIT-COSC2650-SP3-2021-Team-3/security-questions
    
    Add support for security questions when resetting a password pre-auth

commit a4a2b2a6112dee2290c55508674821e49663830d
Merge: 61d5444 314145a
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Thu Oct 21 21:37:15 2021 +1100

    Merge branch 'main' into security-questions

commit 755725f00d44530bb817f99e34bf98b2b51c97da
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Oct 21 16:02:35 2021 +1100

    Miscellaneous tweaks

commit 314145ad50c81a6cfbaf6992066e5130124c18d9
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Wed Oct 20 15:01:03 2021 +1100

    move refreshToken() to appropriate spot

commit 4c1de81521239282b84dc208d5dc1aa620403465
Merge: a8f794f 0825c5f
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Tue Oct 19 21:59:30 2021 +1100

    Merge branch 'main' of https://github.com/RMIT-COSC2650-SP3-2021-Team-3/Squabble-Server into main

commit a8f794ff34dd7e74bc5ac5c44ee1a8a60b8e92e6
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Tue Oct 19 21:59:07 2021 +1100

    Friends & Requests implemented and working with api.
    Ability to get the owner and admin objects from server api with "GetOwner" "GetAdmins"
    Testing and examples of api calls shown in "Controllers/API/UnitTestInstructions"

commit 0825c5f6c48ee3b5510b2ae5b46c93dec21df84f
Merge: 72ab2ca 98e522b
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Tue Oct 19 18:13:16 2021 +1100

    Merge pull request #19 from RMIT-COSC2650-SP3-2021-Team-3/create-team
    
    Simplify create server endpoint. No obvious errors. Merged.

commit 98e522b90af9c340a30e5b9c8d2b63bdca1895e1
Merge: 7e7e6ec 72ab2ca
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Tue Oct 19 18:12:51 2021 +1100

    Merge branch 'main' into create-team

commit 72ab2caf8fe3b4e8c9d902fdfe7cfce1651f3d12
Merge: 456ae3e dfb328f
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Tue Oct 19 16:15:44 2021 +1100

    Merge branch 'main' of https://github.com/RMIT-COSC2650-SP3-2021-Team-3/Squabble-Server

commit 456ae3e114da5d369e7829efa475b0a0731807fe
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Tue Oct 19 16:15:04 2021 +1100

    add function to refresh user token when they log in

commit dfb328f34926f5f107deae42e330dac9048c44fc
Merge: 29b2b77 b6e367b
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Tue Oct 19 16:03:11 2021 +1100

    Merge branch 'main' of https://github.com/RMIT-COSC2650-SP3-2021-Team-3/Squabble-Server into main

commit 29b2b7751bf28d54a9b20693f27c9ccb9126cddf
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Tue Oct 19 16:02:41 2021 +1100

    Testing server pull

commit b6e367ba302756ad490c4e0ca72f908d3e5d10db
Merge: f127431 f71fc59
Author: Duc Tran <55226475+s3500659@users.noreply.github.com>
Date:   Tue Oct 19 13:11:20 2021 +1100

    Merge pull request #17 from RMIT-COSC2650-SP3-2021-Team-3/communicationTokenManager
    
    add token manager class

commit f71fc59f16134909449be90e7a2848fa88b5de85
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Tue Oct 19 13:10:08 2021 +1100

    remove unused param comment and functions

commit bd4df224de52e7f1b1de26c3b67a4bd904e4c5d7
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Tue Oct 19 12:06:51 2021 +1100

    update loginController to use TokenManager

commit 5ff33770c8285272965510d969ad16fc60f8368d
Merge: 210ad99 f127431
Author: Duc Tran <55226475+s3500659@users.noreply.github.com>
Date:   Tue Oct 19 11:51:12 2021 +1100

    Merge branch 'main' into communicationTokenManager

commit 210ad99cfcd4a5dea3dac2e8da34419be88e2c17
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Tue Oct 19 11:48:35 2021 +1100

    add scope for both text and voip communication

commit 61d5444c6593c916501d11a8458fa7976e1cb230
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Oct 18 15:32:52 2021 +0100

    Add support for security questions when resetting a password pre-auth

commit f127431850312269cd832655bccf75f3ac08b6ab
Merge: 1009ed8 154d5df
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Mon Oct 18 18:40:51 2021 +1100

    Merge branch 'main' of https://github.com/RMIT-COSC2650-SP3-2021-Team-3/Squabble-Server into main

commit 1009ed80cc4d87a6569484210ff55dbf445fd1b7
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Mon Oct 18 18:39:52 2021 +1100

    Endpoint for account = GetByUsername

commit 1c09211d4a90c31e76919343d0ed5e47fd67c385
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Mon Oct 18 15:28:29 2021 +1100

    add token manager class

commit 154d5df150f620f9c00d9c99295758cc7e711cc8
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Oct 18 14:02:40 2021 +1100

    Temporary fix for 404 on acs token requests

commit 17ad6a56d17024a38d295bb5b1ef765596bb6d2f
Merge: 7b757c8 e18e120
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Oct 18 10:35:29 2021 +1100

    Merge pull request #16 from RMIT-COSC2650-SP3-2021-Team-3/acs-persistence
    
    Acs persistence

commit e18e120216289f133f5802f2d34019f28daf31cb
Merge: c23449d 7b757c8
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Oct 18 10:34:59 2021 +1100

    Merge branch 'main' into acs-persistence

commit c23449d446cc0d138eb1e1abac9d26f3dd7d48cd
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Oct 18 10:29:01 2021 +1100

    Functional acs persistence
    
    - acs created on register
    - acs returned from get request on account/user
    - acs token refreshed on migration
    - seeded acs data
    - I compared hardcoded token to database token, and it does refresh on migrate
    
    * just need to better organise proactive refresh on client code and run some testing on it

commit 7b757c86f0e115e42044acd83441575afe20c7b4
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Sun Oct 17 22:46:56 2021 +1100

    forgot connectionstring again

commit 70c80a4bbf44e465dace091513782da8ec1f1c05
Merge: 0de0272 6b12a4c
Author: S3807720 <51018322+S3807720@users.noreply.github.com>
Date:   Sun Oct 17 22:36:26 2021 +1100

    Merge pull request #15 from RMIT-COSC2650-SP3-2021-Team-3/server-api
    
    Server api

commit 6b12a4cb71772da90384ff27e1e429fa9797707c
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Sun Oct 17 22:35:43 2021 +1100

    server api should be working

commit 9a814985910959c14f9d2227514ac8209fd201cb
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sun Oct 17 21:29:53 2021 +1100

    Add files via upload

commit 0c7a1908cfe466ab34e9f9ccaa39b0ab08029cb0
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sun Oct 17 21:17:00 2021 +1100

    Add files via upload

commit c405e5b98b09639b61e725d76d413b2b0497d40c
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Sun Oct 17 21:10:18 2021 +1100

    t

commit 3cf3717d2c24058b6bf5a8523f19b1006c02066f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sun Oct 17 20:48:34 2021 +1100

    Added ACS generation and storage
    
    - Creates acs on register
    - Seeds acs on migration
    
    * Missing testing
    * Missing acs token update when proactive refresh executes (I can do that later)

commit 0de02723a0e40a36a88b61b53bea9dc87e007bcb
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Sat Oct 16 23:17:23 2021 +1100

    left wrong connection string. oops!

commit 33baeeb71e6707e5e0b5dd1ec3ad9d5ec06e37c6
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Sat Oct 16 23:11:00 2021 +1100

    fix for server api - ambiguous match exception

commit 5444ceb038e5c5e6dfd08eb71a94254c688c07f6
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Sat Oct 16 11:05:59 2021 +1100

    Channel Endpoints added - DeleteChannel, GetChannel, GetChannelUsers

commit c0eab6181f0703f2bd146415a575d18f028e726c
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Sat Oct 16 10:21:51 2021 +1100

    Added endpoint for servers to get users from a server and the servers a user is in

commit 7e7e6ecfb1f4bd5b508aac5a7b776135c9a90e81
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Oct 15 21:04:49 2021 +0100

    Simplify create server endpoint

commit 6eb21238b55aebeff6921a2c2f2b76fac1938a21
Merge: bd40e9d 8bd7adc
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Fri Oct 15 09:53:04 2021 +1100

    Merge pull request #14 from RMIT-COSC2650-SP3-2021-Team-3/fix-user-registration
    
    Fix storing user password hash when registering for an account

commit 8bd7adce859eca46a3324dac358f6ffca304891c
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 14 15:44:36 2021 +0100

    Fix storing user password hash when registering for an account

commit bd40e9d66f4559bfedd2213fcccac74e0663f73d
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 14 15:32:34 2021 +0100

    Add missing member to ServerManager to fix build

commit 19f37d0d77d6a2da99ce1614620ec6b5a72311a8
Merge: 4de64f3 1b4f7ef
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 14 16:09:52 2021 +0200

    Merge pull request #11 from RMIT-COSC2650-SP3-2021-Team-3/update-account
    
    Build out update account endpoint with validation before update

commit 4de64f3ab90369fd1111a7c336096d8c63a0a488
Merge: a160a1b 27fffc2
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 14 16:09:32 2021 +0200

    Merge pull request #13 from RMIT-COSC2650-SP3-2021-Team-3/Api-Fixes
    
    Api fixes

commit 1b4f7ef1beab8aed1ee39f99172942c0f6200ea2
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 14 15:05:41 2021 +0100

    Implement missing members that derive from `IDataRepo`

commit 852ebfe9993e984fca4a6992086762d11fdd01ae
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Oct 8 11:28:36 2021 +0100

    Build out update account endpoint with validation before update

commit a160a1bcc04b3810e5604a5c9fb0842f0ce1e3a8
Merge: 1fa5858 217421f
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 14 15:55:30 2021 +0200

    Merge pull request #5 from RMIT-COSC2650-SP3-2021-Team-3/reset-password
    
    Add `ResetPassword` endpoint

commit 27fffc2136b218632416224c52c209cace340ac7
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Thu Oct 14 20:57:04 2021 +1100

    Server changed to live from local.

commit 9aa342efea32e76a82b031af0848659f2efd9b54
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Thu Oct 14 20:56:27 2021 +1100

    Server, Channel API added

commit 1fa585886b042da608a9f3b5af0e2b90f0241169
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 14 09:52:20 2021 +0100

    Remove old CI/CD workflow

commit d97b7f731cc8192878929fc4cf1d96e2db5ae341
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 14 09:47:41 2021 +0100

    CI/CD fixes

commit 27c6869f56ef7de98757294a83dca6175db694fc
Author: Mitchell Cash <me@mitchellcash.com>
Date:   Thu Oct 14 10:44:11 2021 +0200

    Add or update the Azure App Service build and deployment workflow config

commit b0269f041b188b972a54d439e3319c677be8dcce
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Thu Oct 14 15:02:00 2021 +1100

    Some fixes, and disabling of friendships for now.

commit 507202f5155d139699bf5d8a058560fe15865cb6
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Thu Oct 14 09:43:07 2021 +1100

    add communicationUserId and token properties for user model

commit 1cd9ea22b9a295df82e8b50b37fea061a996e769
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Thu Oct 14 01:59:01 2021 +1100

    conversations/posts should be fully working.
    Friends mostly done, just final touches before it's ready.

commit a2758f8d523d978ac5ba3650c93bc6748aad510f
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Wed Oct 13 23:50:04 2021 +1100

    conversations and posts should now be working

commit 7150b0b8f6c5cd005e05ec65d692633beb439aa8
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Wed Oct 13 22:15:05 2021 +1100

    fixing bugs

commit 046880505bf91a074d87af669b6ce4dc13db185c
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Wed Oct 13 11:47:38 2021 +1100

    update database connection string again

commit f69a4754b22edb0a4cfad9c92b72e13e99d711cc
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Tue Oct 12 16:22:49 2021 +1100

    update connection string for database and communication services

commit 737959dd4c39f4a08f3a4de60e12d0712a2b482c
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Tue Oct 12 15:56:13 2021 +1100

    Temporary fixes to allow posting to work on the db.

commit d7a96d7c6707c6cdeefc061bfef651d42e99d14a
Merge: a815001 ab8277c
Author: Duc Tran <55226475+s3500659@users.noreply.github.com>
Date:   Tue Oct 12 14:08:06 2021 +1100

    Merge pull request #12 from RMIT-COSC2650-SP3-2021-Team-3/API-revamp
    
    Api revamp

commit ab8277cb8a4b24b50cb4498c62bc0ddc7abf355f
Merge: 01424bd a815001
Author: Duc Tran <55226475+s3500659@users.noreply.github.com>
Date:   Tue Oct 12 14:05:22 2021 +1100

    Merge branch 'main' into API-revamp

commit 01424bd8d65d6b61fccfd76d8867cbcf05440985
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Mon Oct 11 20:19:58 2021 +1100

    async adjusted

commit 5016a41ae5f35a82322b4eb89fc1ff1823cd96f9
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Mon Oct 11 20:12:13 2021 +1100

    Claims added

commit 27b268093415b56bbd7110b3615b625074a02cdf
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Mon Oct 11 20:09:29 2021 +1100

    Changed get to
    return _accountManager.Get(FindIdFromToken(HttpContext.User.Claims));

commit c8bcb8e166960f76540bd04152bb0f80f8129a2b
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Mon Oct 11 20:03:58 2021 +1100

    Added Friend List, Requests.
    Renamed Account to User.
    Rearranged the server/channels to support a user focus rather than role focused set up.
    Database enabled for all features.

commit a815001838d5377b74677a597ae09e30177ce2a9
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Oct 8 15:53:49 2021 +0100

    Specify both prod and dev site wildcard URLs for CORS whitelist

commit a98e3abcf6c4d40ac2a3faf9d497b135a111458c
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Oct 8 12:23:48 2021 +0100

    Lower GitHub Action artifact retention period to not hit storage limits

commit fe70fdcce0ee2de230286ae1ce496cce18cb5853
Merge: 5b1f26a 3387449
Author: Duc Tran <55226475+s3500659@users.noreply.github.com>
Date:   Fri Oct 8 21:06:53 2021 +1100

    Merge pull request #10 from RMIT-COSC2650-SP3-2021-Team-3/text-chat-api
    
    add user identity creation without token

commit 3387449de384c8ef910efb109ff0c98f3568cf2d
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Fri Oct 8 16:05:35 2021 +1100

    add user identity creation without token

commit 5b1f26ac5ac1b88df3f3a94374ad85762ec41483
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 7 10:25:11 2021 +0100

    Update wildcard CORS policy for dev sites

commit ed2e52bf4cec1d61b89ddcb08dba1e2c56e57203
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 7 08:36:19 2021 +0100

    Fix CORS issues in prod

commit f17049e04bee8ffa7f80bc0d05dcf61b01d25983
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Oct 7 17:38:45 2021 +1100

    Seeded Another Account and Login

commit f30972f6b85c8ac6890a78755fcd7f8b08a91431
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Oct 7 13:44:52 2021 +1100

    Bug Fixes
    
    - Account id is no longer only returning 1
    - Account id has been removed from Account parameters and instead gets account id from JWT claims

commit 373950cf5822288968b1b5e922d3d3fb5be4a56b
Merge: d05224b f342d7e
Author: Duc Tran <55226475+s3500659@users.noreply.github.com>
Date:   Tue Oct 5 13:30:23 2021 +1100

    Merge pull request #9 from RMIT-COSC2650-SP3-2021-Team-3/azure-text-chat
    
    Azure text chat

commit e5448a4dba67bde727c3ee95cba766a6e4968bd2
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Tue Oct 5 13:14:44 2021 +1100

    Incorporated Vinh's startup./appsetting updates

commit f342d7ec51461f1301e1dd6368a3c9f3bf8d3a06
Merge: 71b1ef8 d05224b
Author: Duc Tran <55226475+s3500659@users.noreply.github.com>
Date:   Tue Oct 5 12:37:35 2021 +1100

    Merge branch 'main' into azure-text-chat

commit 71b1ef8ab1d38be33b4d5060678cde2d475fd6c8
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Tue Oct 5 12:30:43 2021 +1100

    minor token controller refactor

commit 217421fd618fe707c24b5c2850b722bccd144650
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Wed Sep 29 17:13:10 2021 +0200

    Add `ResetPassword` endpoint

commit 120b03682849fd8a9db27c112fe307b7b2f83856
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Tue Oct 5 00:00:09 2021 +1100

    Post API added - attachment support added.
    Instructions are commented, is a bit complex, but should be future proof, maybe some adjustments later?

commit d05224b865ce4961dff8b499d5edd6385c58b14e
Merge: d5ea336 579e089
Author: S3807720 <51018322+S3807720@users.noreply.github.com>
Date:   Mon Oct 4 11:46:04 2021 +1100

    Merge pull request #7 from RMIT-COSC2650-SP3-2021-Team-3/API-revamp
    
    simplified the accounts api, a lot of current functionality will break

commit 579e089663aef7ae7eb99b692d8ca32470342d65
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sun Oct 3 21:26:48 2021 +0200

    Return `account_id` in JWT so frontend can utilise new account endpoint

commit 45f20cdc8858dbe4c15fd437f3b93eec01d4c7f2
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sun Oct 3 20:33:13 2021 +0200

    Fix build errors

commit d5ea336814df33e130409a36964daf83a449a75c
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sun Oct 3 20:22:51 2021 +0200

    Allow any origin CORS request
    
    Not something I would usually do, but this better enables our auto
    deployed testing sites to work.

commit 98d74ebdf7a5a081f4fa63d18036bd9add4dd593
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Sat Oct 2 17:52:36 2021 +1000

    simplified the accounts api, a lot of current functionality will break

commit 90e93e142d39225c7bbbbf31bbd1bb28ddcf08d0
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Thu Sep 30 17:15:32 2021 +1000

    Fixed errors

commit 8420728d65efe6a341e43faad06b15d46d268fb0
Author: Luke Smith <s3807720@users.noreply.github.com>
Date:   Thu Sep 30 17:01:44 2021 +1000

    Changed server/group makeup, added some validation and changed error messages.

commit ecbbac161a8ab2ac217aa8c23767d7702aa55fd8
Merge: 30c4bea add14d6
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Sep 30 13:23:48 2021 +1000

    Merge pull request #6 from RMIT-COSC2650-SP3-2021-Team-3/Identity-Alternative
    
    Identity alternative through custom login logic

commit add14d6723699b4719a75c2201b545013d8d58da
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Sep 30 13:22:45 2021 +1000

    Full Identity Replacement
    
    - Replaced Identity ASP.NET Core with basic custom login logic

commit f4020ea0119ef9db124533bdc7298d201485d623
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Sep 30 12:26:54 2021 +1000

    Started Identity Replacement

commit 4d5cf8994e95c2cf0c918a42eb0fb304805da49c
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Wed Sep 29 18:16:29 2021 +1000

    create basic api for token generation and refresh

commit c130116ae851f196c3dec79cf7fdf3facda95b72
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Tue Sep 28 17:44:31 2021 +1000

    add token manager for Azure text chat function

commit 30c4bea32523cb6a67d1b0c5863b19326f047fef
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Sep 27 07:04:41 2021 +0100

    Test updated publish-profile in CI

commit 26b5acbe22d8986fd713ed7dfc63210cb5ea5993
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Sep 27 06:56:31 2021 +0100

    Specify solution file on `dotnet publish` CI stage

commit 9ccd353f104e41ac43cb10e613cb22fbd7dfde30
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Sep 27 06:51:24 2021 +0100

    Bump dotnet version in CI and specify solution file

commit f315008415e1fe95ea5d1c56f4b401d1cc4f77b4
Author: Mitchell Cash <me@mitchellcash.com>
Date:   Mon Sep 27 06:48:29 2021 +0100

    Add or update the Azure App Service build and deployment workflow config

commit bdfa67007fb14f8ae5ac70341c9c2451fd046067
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Sep 27 05:56:05 2021 +0100

    Add support for Microsoft SSO

commit 7b2a6679dea53e56d62823c93bb2209d6d4da142
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sat Sep 25 15:49:26 2021 +1000

    User base class
    
    - Reduced code duplication with a base class for shared RegistrationRequest and Account properties

commit d3229c3e3ff7f204d71513274924b8688bcccf4a
Merge: d2af17a b0f33bf
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sat Sep 25 15:48:15 2021 +1000

    Merge pull request #4 from RMIT-COSC2650-SP3-2021-Team-3/Model-Annotations
    
    Improved annotations

commit b0f33bf49807f88cb067d71bacdadc6d6523b891
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sat Sep 25 15:17:24 2021 +1000

    Improved annotations
    
    - Added and updated to Account.cs model and RegistrationRequest.cs model data annotations

commit d2af17a58cd096397a85e68ca12fa8da13bbf203
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Sep 24 15:16:42 2021 +1000

    API V1.2
    
    - Login works
    - Registration works with local login provider
    - Account data can be retrieved in JSON with JWT

commit 76927dddf633de82820b5d4f8105a738efc663ea
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Sep 24 15:14:43 2021 +1000

    Changed Structure

commit bd37863bdb3ff3a4b1630c9c83839c3538e2f35c
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Sep 24 15:11:26 2021 +1000

    Client Code Unnecessary

commit 57bfb8093af248216d453ae691eaba67e510075e
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Sep 23 17:06:13 2021 +1000

    Functional Local Login + More
    
    - Migrations used on deployment automatically
    - User login and signup works
    - Minor fixes
    - Started working on Account access (formerly known as the User model)

commit bd5acd25fbbb7b5b286866e46d4adeb77b8b016d
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Sep 23 11:52:29 2021 +1000

    Local login provider implementation
    
    - Added local sign in and sign up methods
    - Added GetUsername and GetEmail methods for testing auth
    - Additional fixes and improvements

commit a67ef86648b996e67700d79cac21be01b5ed3a91
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Sep 22 16:39:51 2021 +1000

    clarification

commit bcaa958942199b5eced852ac02b7b1dec3e0914d
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Sep 22 16:24:29 2021 +1000

    Updated summary

commit 725587af6fcd5856d5b1f24bab4d91d4068bd736
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Sep 22 16:23:41 2021 +1000

    Update
    
    - Functional get method with bearer token as authority
    - Minor fixes
    * Scrapped random key generator in JwtConst for now
    * Scrapped custom authentication scheme for now

commit 9072dd24bcc73bedb88faef4cc612476225c2044
Merge: 3ddc6d9 f9406c2
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Sep 22 14:20:07 2021 +1000

    Merge pull request #3 from RMIT-COSC2650-SP3-2021-Team-3/Database-Context-and-Seeding
    
    Database context and seeding

commit 3ddc6d984f85deeeea11665fe40c48e90831c0ce
Merge: 9872242 728c75e
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Sep 22 14:19:43 2021 +1000

    Merge pull request #2 from RMIT-COSC2650-SP3-2021-Team-3/Authorization-and-Authentication
    
    Authorization and authentication

commit 9872242c606a1335df08fd72da12d77d9fb6757e
Merge: 4433c4b 24ebe8e
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Sep 22 14:19:18 2021 +1000

    Merge pull request #1 from RMIT-COSC2650-SP3-2021-Team-3/Code-First-Models
    
    Code first models. Only ApplicationUser is enabled for now

commit 24ebe8e4be5b4ba3a826d5b267ecb85c8592c6d1
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Sep 22 14:18:19 2021 +1000

    Updated Models
    
    - Minor fixes
    - Added ApplicationUser custom IdentityUser

commit f9406c2aad1f8af328953f730c8f4c1ef3a30606
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Sep 22 14:17:24 2021 +1000

    Simplified DbContext
    
    - Only includes Identity tables

commit 728c75e959db57f1c466941fd5e2858efa1a212c
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Sep 22 14:16:39 2021 +1000

    Skeleton Code and Authentication/Authorization
    
    - First publish of full web api project
    - JWTs generate properly
    - Migrations only include Identity tables now (through IdentityDbContext inheritance)
    - My non-Angular testing Client code is still present but separated in a root folder

commit 4eddfe311b5434dad24da2a2faa68593dc75e5c6
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Sep 22 14:08:40 2021 +1000

    Skeleton Code and Authentication/Authorization
    
    - First publish of full web api project
    - JWTs generate properly
    - Migrations only include Identity tables now (through IdentityDbContext inheritance)
    - My non-Angular testing Client code is still present but separated in a root folder

commit d2c24cb661c167411a758b6e4b4db7e6f5d0a605
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Sep 20 11:31:50 2021 +1000

    Minor Update
    
    - Added data for seeding User Mobile
    - Attempted a Fluent API composite key for Friend Code-First model

commit fa3beab6a74c7c08ef533400c562158b1ca38bef
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Sep 20 11:30:26 2021 +1000

    Updated Model Properties

commit cdcc5452799ca004882678ee36c7e4bd5437a6f1
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Sep 20 09:51:40 2021 +1000

    Added Avatar model code
    
    - Skeleton code for Avatar seeding
    - Added DbSet of Avatar
    - Removed commented out code in OnModelCreating method

commit d6db7f12cb4904e2e3abc51b4fe1598e9513135b
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Sep 20 09:50:05 2021 +1000

    Replaced by Avatar.cs

commit cd71875cda19cf280d74ac3430d041f89322297a
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Sep 20 09:49:36 2021 +1000

    Added Avatar DbSet

commit fed47b8e3cc4faa0a21208288c7a3de48664b904
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sat Sep 18 11:52:05 2021 +1000

    Initial Progress
    
    * Functional data seeding for models
    
    - Initial Squabble context
    - Initial Seeding file

commit 0a4fce4fc13d480f342e1eff027dd6fe573c3ea8
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sat Sep 18 11:49:57 2021 +1000

    Updated Models

commit 03bd6e589453c81f5c8da957454ed73c88cd09d5
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Sep 13 12:46:51 2021 +1000

    Functioning Model
    
    - Added a few more models
    - Progressed with data annotations and model properties
    
    * Models are able to be seeded through a dbcontext

commit ce4c99c1996742cb609a361bfbdce29fef0173e8
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sat Sep 11 12:28:05 2021 +1000

    Started Drafting Models
    
    - Created and begun working on some of the possible entities for database

commit 4433c4b849b9675efea68c1f1512d7402160b937
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sat Sep 11 12:09:40 2021 +1000

    Update README.md

commit 5b414d4a0f2b9e081dade195e980ee8a62e96629
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sat Sep 11 12:08:13 2021 +1000

    Initial commit
