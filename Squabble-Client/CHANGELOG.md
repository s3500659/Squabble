commit ddde729aaeb64e9469bf16e4ff919c232c5477b1
Merge: 8c5afac b1e5a17
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Nov 27 19:29:06 2021 +0100

    Merge pull request #83 from RMIT-COSC2650-SP3-2021-Team-3/comments-cleanup-gerard
    
    Comments cleanup gerard

commit b1e5a1763b725ad78c72eae1f7a9d4573dcb8222
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Fri Nov 26 16:33:10 2021 +1100

    Added error for no username entered in search for add friend

commit 3ff076e683e2bf4dbb51a1e5d6b1b54e3869bebc
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Fri Nov 26 14:25:53 2021 +1100

    Delete unused spec files, added comments, some code tidying of removing excess blank space

commit 733e6e3776f64b354ff2d8abb1dcc0d070d27db6
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Fri Nov 26 12:01:56 2021 +1100

    Added snackbar for user not found on add friend

commit 72631b9b9bcf39ce08676e2801f9acf76b661323
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Thu Nov 25 16:39:44 2021 +1100

    Added alt test for MS logo on login page

commit 8c5afac3fea71e0cdd76114ee73fa23d44b13b13
Merge: 3be6b6f 8240efa
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Sat Nov 27 10:36:28 2021 +1100

    Merge pull request #84 from RMIT-COSC2650-SP3-2021-Team-3/initial-render-delay-fix
    
    Tested branch locally. Fixes bug. No obvious issues.

commit 8240efaa2c7e5e9d08914af8d04fb13d547d0863
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sat Nov 27 10:29:18 2021 +1100

    Added delay for remote render on connected status

commit 3be6b6f1d33306da722f76267570fd3303eeba32
Merge: ad18c12 f968014
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 26 16:58:39 2021 +0100

    Merge pull request #81 from RMIT-COSC2650-SP3-2021-Team-3/failed-initial-video-name-load-bugfix
    
    Failed initial video name load bugfix

commit f9680147657176859f51892e8295055ca63eb1ed
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 26 14:25:56 2021 +1100

    Fixed duplicated video+displayname of caller

commit bdcc30f5ff7922c13e1c1f7edfe504a7ffd58251
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 26 13:42:17 2021 +1100

    Code Cleanup, Comments, and removed Console Logs

commit 4c59d12913dbe20fc2c27492373f20184896ef07
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 26 13:41:52 2021 +1100

    Add files via upload

commit cc43288efba8761ddc12d31a966b5b609a577e5a
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 26 13:41:32 2021 +1100

    Code Cleanup, Comments, and removed Console Logs

commit a0ccf12c38010c2672bf2ceac982c6f51a55f0bb
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 26 13:41:11 2021 +1100

    Code Cleanup, Comments, and removed Console Logs

commit a5e7cfdf30660dccd6d24c322d7c4bb8fdc81c0c
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 26 13:40:37 2021 +1100

    Code Cleanup, Comments, and removed Console Logs

commit b2f4b7c2a468a0d189a369ab5ae454051c7217bb
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 26 13:40:17 2021 +1100

    Code Cleanup, Comments, and removed Console Logs

commit a774e3fd53bdf450bbf1d91afff6b2c9509ae94a
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 26 12:06:26 2021 +1100

    Adjustments
    
    - Fixed view load issue for caller in friend calls and group calls
    - Added in fix for when a member of a channel tries to call the members of a channel while they are midcall, the callees in that call are still removed from the call
    - Made the text inside the participant management dialog black instead of white
    - Added try catch to error-prone code
    - Cleanup and minor comments
    
    * New bug exists where when a callee of a group call leaves a call, the caller's video is duplicated in that callee's video place for remaining callees

commit 3b0441d2575e2296183b90c51c64927fa8b0e6cc
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 26 12:03:05 2021 +1100

    Adjustments
    
    - Added try catch to error-prone sections
    - Cleanup

commit 40ceaae0ae879bdc3cc57b47b7497ba717dafaa2
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 26 12:01:41 2021 +1100

    Adjusted incoming call handling
    
    - Fixed bug where after leaving a group call, if you try to call the group while they are still mid-call, the callees of the call still get kicked out

commit ad18c123bff0d89112feab13d13c1b818d69b533
Merge: f1d00da 9faa552
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 26 16:32:52 2021 +0100

    Merge pull request #80 from RMIT-COSC2650-SP3-2021-Team-3/calling-user-hangs-up-call-bugfix
    
    Calling user hangs up call bugfix

commit 9faa552727dbd1b7fba23c7eae234becc737aa3f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 26 10:40:41 2021 +1100

    Fixed call kick on invite
    
    - Adjusted the CallEnded event logic
    - Cleaned up code and added in comments
    - Also fixed a bug where after ending your call, when you call that same person again, they don't get a call notification
    - Added in a snackbar telling the user receiving a call when already in one of the missed call and who called them

commit dee85bd8a8f593bf53528ec72ec5a325d819e56b
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 26 10:38:09 2021 +1100

    Add files via upload

commit f1d00da556ffa6ccfdf822e9d29d6e500d0ffbde
Merge: bebdd9e 065151e
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 26 16:17:32 2021 +0100

    Merge pull request #79 from RMIT-COSC2650-SP3-2021-Team-3/perf-load-time
    
    Dramatically improve page load time when loading app after login/refresh

commit 065151ef8878bc3cde1a0e457215d7d5d38afae2
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 25 16:44:29 2021 +0000

    Dramatically improve page load time when loading app after login/refresh

commit bebdd9e640f1b56c49dbd32b73670ecc6922257a
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 25 17:32:05 2021 +0000

    Lazy load all the call components for better performance

commit ed42c86d84599d5480ce1bf98b93d2946681d5b9
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 25 17:07:08 2021 +0000

    Fix manage users tooltip location and message

commit b3de7a9ca45ab49909ca09c8f48f39c66350dee9
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 25 15:33:37 2021 +0000

    Show success notifications after successful profile/password updates

commit 5fb85fa4d2aa5408e64f1ba947fce50db00d84da
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 25 15:21:24 2021 +0000

    Resetting password pre-login show errors when fetching sec questions

commit 1f82c7943f473d80eacdd587c7f1cc390e254150
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 25 14:52:18 2021 +0000

    More perf updates
    
    - Remove some unused modules/components
    - Remove some unused HTML
    - Keep refactoring pages into modules to reduce main JS size

commit 5b45cd1a282f9ba0ec1b6fa3bc6a35ce9f6ee35f
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 25 13:52:40 2021 +0000

    Lazy load components to improve performance

commit 5bdfe386abef6c1f6cb5a2d6b0f97a364b2af8c9
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 25 13:44:29 2021 +0000

    Add font display swap when fetching Material Icons to improve perf

commit 8ae88bf58f63951c9d6ef67242a76c472f6e58d1
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 25 13:41:41 2021 +0000

    Replace favicon with Squabble icon

commit 98df21a0759f856e882d428c8dea42ecff89b582
Merge: 7ddac84 0eb9d8d
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 25 13:35:30 2021 +0100

    Merge pull request #77 from RMIT-COSC2650-SP3-2021-Team-3/remove-user-from-server
    
    Remove user from server

commit 7ddac84cccb96d5add922517d4ecb39f9ecb21aa
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Thu Nov 25 19:03:11 2021 +1100

    Update delete-kanban-confirmation-dialog.component.html

commit 8bd757474f928d7807f8763a491564edfeec8114
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Thu Nov 25 18:46:47 2021 +1100

    Remove settings button from postLoginLayout

commit f477108a8510d30638bca2ce580a455bf4e7e2b2
Merge: bc3a07e 1848cf1
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 25 12:31:32 2021 +1100

    Merge pull request #74 from RMIT-COSC2650-SP3-2021-Team-3/bugfix-371
    
    Bugfix 371 -Timeout Handling

commit 1848cf17c579edc2965a4ceb52311f637164bea3
Merge: 37fc898 bc3a07e
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 25 12:20:59 2021 +1100

    Merge branch 'master' into bugfix-371

commit bc3a07e7d1b581305300500b700ee0e4b5638311
Merge: 3d72c79 2f4e6e4
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 25 12:10:45 2021 +1100

    Merge pull request #78 from RMIT-COSC2650-SP3-2021-Team-3/call-participants-grid-layout
    
    Call participants grid layout. Remote participant display name's first load as "undefined" for now.

commit 2f4e6e4166e4ec520ae6ecd9916b1925bbfcbe95
Merge: cf7e91c 3d72c79
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 25 12:10:14 2021 +1100

    Merge branch 'master' into call-participants-grid-layout

commit cf7e91ca5fb9bc56fcf2a2b2366859559a4d1aa3
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 25 12:08:38 2021 +1100

    Added device permission request

commit 0b6e3df7046c48bbf2fa71974641b1b93a3aa39c
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 25 12:08:06 2021 +1100

    Removed unused code

commit 15e5e85f66b4baa620b0be27e819150504836dc7
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 25 12:05:58 2021 +1100

    Add grid layout on caller's side

commit 0b6e8cde569d1e15b7a5567f71aeaf5e93d72b8f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 25 12:05:20 2021 +1100

    Added grid-layout for callee's side

commit 0eb9d8d18e0c2a1adf672fcb0352a0121e69fb93
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Wed Nov 24 22:20:25 2021 +0000

    Add tooltip how to use server user management

commit 3d72c79903b3f5cadfe7c9ce309cfed0f1415a32
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Thu Nov 25 09:18:56 2021 +1100

    fix code presentation for service class

commit 0e0507c9377f1b4a7943baddde5da7e0de45a962
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Wed Nov 24 22:09:11 2021 +0000

    Remove member from server

commit 38a31a6c789a4e113cbae39a5bba2f9a742d78ec
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Wed Nov 24 21:56:29 2021 +0000

    Bump dependencies

commit 8fbc2e763e261703c83a1c5eef6ae7be83123c3d
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Wed Nov 24 20:27:46 2021 +0000

    Bump style size budget

commit d9205823017ef29571399a591cdc5100df51cfad
Merge: ccf2107 8c423bf
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Wed Nov 24 21:21:33 2021 +0100

    Merge pull request #75 from RMIT-COSC2650-SP3-2021-Team-3/bugfix-368-365
    
    Bugfix 368 365 - Manage Channels button is now Add Member button

commit 8c423bf0bb936307c32c7e643e2a38653042dcad
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Wed Nov 24 20:20:31 2021 +0000

    Update user list on server component after adding user

commit ccf210754b53225910eca7793fd0800b305df3ca
Merge: 6f014de 484946e
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Wed Nov 24 19:04:22 2021 +0100

    Merge pull request #73 from RMIT-COSC2650-SP3-2021-Team-3/bugfix-311
    
    Changed Add Friend input label to "Search Users"

commit 6f014de8d52a8a78024389a0ef87c17922b3e344
Merge: c69f760 6d711a8
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Wed Nov 24 19:02:47 2021 +0100

    Merge pull request #72 from RMIT-COSC2650-SP3-2021-Team-3/bugfix-221-193
    
    Bugfix 221 193

commit 6d711a827a362c70acb25a412aab3195e3fdff4c
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Wed Nov 24 18:02:26 2021 +0000

    Add some additional text to the add user to channel error message

commit c69f760f2475e94c6285dfc3fd00a0c9297e3b56
Merge: 0387209 2d48904
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Wed Nov 24 20:42:40 2021 +1100

    Merge branch 'master' of https://github.com/RMIT-COSC2650-SP3-2021-Team-3/Squabble-Client

commit 0387209cd44b8d135369ffd90adf49d29c540ae5
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Wed Nov 24 20:42:07 2021 +1100

    fix code presentation for types classes

commit 2d4890421fd82045a4c7321273d1ea59009247a9
Merge: 7620cff 9854e27
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 24 17:56:12 2021 +1100

    Merge pull request #76 from RMIT-COSC2650-SP3-2021-Team-3/no-cam-image-update
    
    No cam image update

commit 9854e27fc9107d473c963c8b10c228ee9eb1ff18
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 24 17:55:14 2021 +1100

    Changed image source for no video source selected

commit 7755addb45b0cc64d6a08911ae453d3c23d0bb09
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 24 17:54:10 2021 +1100

    Removed old image for no selected video source

commit 14ff616ff18a3d7186118754060cef6746a2d144
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 24 17:53:41 2021 +1100

    New image for no selected video source

commit 55938ae98cae3fc5557ae22c41a2d7cd0821d591
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 24 17:25:17 2021 +1100

    Bugfix
    
    - Manage Channels button now adds a user to server
    - Buttons were restyled
    - Button names altered

commit a0d653b8c6d8916346fd6bf9103e583b3c7c01ab
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 24 17:23:56 2021 +1100

    Changed button name
    
    - Add Users -> Add Member

commit 37fc898f44eb82322d740a300390ecad84b99047
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 24 16:58:16 2021 +1100

    Worked on timeout notification
    
    Now holds the call notification dialog and the associated events

commit 154d727510ef2cc98dd0d6550b423e73b48d6fec
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 24 16:57:24 2021 +1100

    Worked on timeout notification
    
    - Styled select list of devices to black font
    - Snackbar messages implemented

commit 206a61740d1a4ec995c6f571ff7361a23d34711f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 24 16:55:48 2021 +1100

    Worked on timeout notification
    
    - Removed notification event handling and modal ref for calls (now sits in call client service)

commit f55a05bdbd5835418ca74214bb00555ec792c1d5
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 24 16:54:56 2021 +1100

    Worked on timeout notification

commit fd210b277a49791114a81c91f13b5a353e293e34
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 24 16:54:35 2021 +1100

    Worked on timeout notification

commit 4dd111dad137f0b27206c846f6668ca961c20f4e
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 24 16:54:09 2021 +1100

    Worked on timeout notification

commit 484946eebe24e98b956feb401f5c4b2b7c76c217
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 24 12:20:48 2021 +1100

    Changed Add Friend input label to "Search Users"

commit 824cd57f91a72873502d4d545b4f6383bf666ed2
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 24 11:42:17 2021 +1100

    Styled input as black

commit a26c23ee100dfa8cc61e18cb370ddb9e11f124a2
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 24 11:38:55 2021 +1100

    Added add user error notifying

commit 7620cffbab4ec9d74ce2d5c45c156badd7cbf7d9
Merge: fe03f94 9527730
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 24 10:10:06 2021 +1100

    Merge pull request #69 from RMIT-COSC2650-SP3-2021-Team-3/deny-blank-team-name
    
    Added Null Input Block

commit 9527730d1e7b95a5804d09899e3be72279e58a0c
Merge: 3f2bee1 fe03f94
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 24 10:09:38 2021 +1100

    Merge branch 'master' into deny-blank-team-name

commit fe03f94115b5062487cbcc9f365fae67adf4c97a
Merge: 42ed5ae 4d15894
Author: Duc Tran <55226475+s3500659@users.noreply.github.com>
Date:   Wed Nov 24 09:58:31 2021 +1100

    Merge pull request #71 from RMIT-COSC2650-SP3-2021-Team-3/vinh-bugFix2
    
    Vinh bug fix2

commit 4d1589479adb3896974c1718d0ae8dca88089204
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Wed Nov 24 09:20:26 2021 +1100

    remove href on <a> tag for chat inner

commit 42ed5ae43ed259e6e1f57b78047dcbc1a293acbd
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 24 09:13:02 2021 +1100

    Added try catch to call agent instantiation
    
    - Reloads page if call agent fails to instantiate

commit 402d4faef6e9926fff38132cd4b92d30f94b76ae
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Wed Nov 24 09:04:55 2021 +1100

    add some code comments

commit 63594801b3b1abbdfcd1b352434e0fc993380206
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Wed Nov 24 09:00:18 2021 +1100

    fix bug where user can submit message by pressing enter even when message button is disabled

commit 6747fca6d4414b80f025539b7ddfe693f7fc3658
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Wed Nov 24 08:55:52 2021 +1100

    remove console.log() not in try-catch

commit 94ac2bad2992d12dd608c69a2962165fc1ec52e0
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Wed Nov 24 08:52:25 2021 +1100

    disable chat send button when input field is empty & fix customElementSchema error relating to NgxDropzoneModule

commit 5ad63275c5b50c47bdd4a708164cdf7745c66019
Merge: ff12166 6e34ba5
Author: Duc Tran <55226475+s3500659@users.noreply.github.com>
Date:   Wed Nov 24 08:21:22 2021 +1100

    Merge pull request #70 from RMIT-COSC2650-SP3-2021-Team-3/call-ui-updated
    
    Updated and cleaned UI / Dialogs

commit 6e34ba514944ff629e7a0269a67918f61a94384b
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Wed Nov 24 08:06:55 2021 +1100

    Update kanban.component.scss

commit d0dce15361d1f2128b2fdcaf4abf4a1547c31fd2
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Wed Nov 24 08:00:54 2021 +1100

    Updated Dialogs and styling across Squabble

commit 3f2bee192b8d3b49f075b520b354d12a48f12152
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 23 15:55:33 2021 +1100

    Added Null Input Block
    
    - Blocks blank team name
    - Shows snackbar error message
    - Snackbar error message is closed if the duration is ongoing and the user enters a valid team name after an invalid one

commit ff12166be241584628d19b657e073d4f8dc9bee6
Merge: 25ac6ef 1513b51
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 23 14:24:26 2021 +1100

    Merge pull request #66 from RMIT-COSC2650-SP3-2021-Team-3/restyle-call-add-kick-list
    
    Changes:
    
    Add/Kick dialog box for caller who is admin/owner
    Hides buttons on call end with a call end message
    Only 1 call notification popup. Still needs to not stall the UI.
    Placeholder image in local preview when no video source selected
    Join Call button is Start Call instead for Caller
    Minor restyling and code cleanup.

commit 25ac6efa4df82f5f2b1f99951805b93b98d0f897
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Nov 22 17:21:02 2021 +0000

    Replace server menu item from drag icon to menu icon

commit b829b7eb21349eab53fec3ff2ff6f9714e1665e4
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Nov 22 17:13:17 2021 +0000

    Don't load avatar image from Azure if none uploaded

commit cfda1b6346953b41f45b6933fe674e66814a5536
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Nov 22 16:59:07 2021 +0000

    Ensure passwords match when updating from profile view

commit bb89d398490c16bb969ed8717eb25ee9bb643706
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Nov 22 16:49:26 2021 +0000

    Add X-Frame-Options: SAMEORIGIN security headers to site

commit e03bdb28af6b02c565621cb504cdbd2708c73268
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Nov 22 16:40:05 2021 +0000

    Remove unused items from side menu

commit d0359c65482eeb18c0f624abaf98f1c775242e77
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Nov 22 16:34:11 2021 +0000

    Ensure update profile/password forms can't be submitted when invalid

commit 917f2d169528453cdfe110cdccbb1bc74753845f
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Nov 22 16:28:33 2021 +0000

    Remove unused "Admin" menu item in team menu

commit dd8f6263d5414cadba1e9dcb98492a1135e30070
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Nov 22 16:24:44 2021 +0000

    Safari can't enumerate call devices due to OS limitation

commit a38d62e6b4cb0df30169f88e8518bc0edf58efac
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Nov 22 16:24:08 2021 +0000

    Replace menu icon

commit cc44d7fdca656b612369f941b2a3cf6184cdf8ec
Merge: 88071ef 302b969
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Nov 22 18:35:50 2021 +1100

    Merge pull request #67 from RMIT-COSC2650-SP3-2021-Team-3/hanged-login-refresh
    
    Added Try Catch Refresh

commit 302b969172565376556422546a11f3051b9f334d
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Nov 22 18:33:43 2021 +1100

    Added Try Catch Refresh
    
    - Reloads the page if the Azure Token Credential fails to get created.

commit 1513b5180e4d562342d9fda18243c22051882793
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Nov 22 16:07:45 2021 +1100

    Minor Styling Improvements
    
    - Added placeholder image for when the user has no selected camera in local preview
    - Changed the Join Call button to Start Call if the user is starting a call

commit 961320296f2b608486760d55d4bf2c26a1352419
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Nov 22 16:06:14 2021 +1100

    Placeholder Image for video source

commit 75797d0bebbb12a13f6a0194c61600ee038f2b5b
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Nov 22 15:03:36 2021 +1100

    Minor restyling and code cleanup

commit 7131ddf584929318a465ba5e7100dc9e6920340a
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Nov 22 15:02:50 2021 +1100

    Minor changes

commit 0923c01035a2ea65c7739f67c79bbe16f2216aeb
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Nov 22 15:02:18 2021 +1100

    Restyled call button

commit 0b08a62bf439e4afb69eab9616e885509340358a
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Nov 22 15:01:40 2021 +1100

    Bugfixes
    
    - Updated add/kick select menu
    - Hides buttons on call disconnnect
    - Conveys to the user that a call has disconnected
    - Other fixes/restyles

commit e31722a2d255c1119ad0a3cf2e9d751e690b75d1
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Nov 22 15:01:10 2021 +1100

    Changes
    
    - Updated add/kick select menu
    - Hides buttons on call disconnnect
    - Conveys to the user that a call has disconnected
    - Other fixes/restyles

commit 0794a1c29c2d7049fc9b088cc8369edf42ecd117
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Nov 22 14:59:37 2021 +1100

    Added flag for dialog box bugfix

commit e1d1e83699552f9b97586f59128798cd5fe42a3b
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Nov 22 14:58:57 2021 +1100

    Buigfix
    
    - Added flag that stops it from loading multiple instances

commit 88071eff427a15be322f6d260a6d4c7d10e529dd
Merge: 0611c4f f6e16c1
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Nov 22 12:32:24 2021 +1100

    Merge pull request #65 from RMIT-COSC2650-SP3-2021-Team-3/restyle-caller-callee
    
    Restyle caller, callee, and local preview + Bugfixes

commit f6e16c1061903e93f9a6aae725cca2b0471edf3d
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Nov 22 11:06:28 2021 +1100

    Minor Cleanup
    
    - Removed unused code

commit b9bd764c052654c389e369d765699724bf491450
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Nov 22 11:05:47 2021 +1100

    Bugfixes
    
    - Tidier code
    - Minor stability improvements

commit 8ec9083cc80b9d5b55ea8b6fb4aa7aee2755799a
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Nov 22 11:04:31 2021 +1100

    Bugfixes
    
    - Tidier code
    - Video render is now disposed of properly when having left a call

commit 3e2f7fc50c3047ef88f2af94d79370cc525025eb
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Nov 22 11:04:01 2021 +1100

    Buxfixes
    
    - Tidier code
    - Video render is now disposed of properly when having left a call

commit 0611c4f978ec124002ee6384946c730e0ba90efb
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sun Nov 21 10:07:47 2021 +0000

    Update communication endpoints

commit 511f531c717fe9cc23868708ff093e44af03f1af
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sun Nov 21 13:27:17 2021 +1100

    Restyle/Fixes
    
    - Restructured the logic
    - Fixed the mute icon toggle
    - Implemented end call on redirect
    - Starts call on page load instead of having a separate start call button

commit c343972714a66dedb12ee5f85123325321425ba4
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sun Nov 21 13:25:58 2021 +1100

    Restyles/Fixes
    
    - Removed add/kick logic
    - Restructured the logic
    - Fixed the mute icon toggle
    - Implemented end call on redirect

commit e5a5547803d9564bcf93dd513b1c484584812c88
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sun Nov 21 13:24:22 2021 +1100

    Fixes/Restyle
    
    - Removed mute toggle button
    - Fixed camera not showing for No Camera -> Camera select
    - Minor adjustments

commit a615b4c604b0afba765fe01bd8781df08dcaef5b
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sun Nov 21 13:23:04 2021 +1100

    Adjusted conditional for incoming call

commit d120ecafbbf671c35d39029950201a24c46d4e10
Merge: b716ce3 b76699e
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Sat Nov 20 12:49:24 2021 +1100

    Merge pull request #64 from RMIT-COSC2650-SP3-2021-Team-3/revert-63-revert-54-file-upload-chat
    
    File upload dropzone and blobservice

commit b76699e772573e49ca9a23fec602cfebbd3aeb46
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Sat Nov 20 12:49:09 2021 +1100

    Update chat-inner.component.ts
    
    Entered changes from branch directly into file due to error with resolve conflicts.

commit d59f7321405f6d7f59428ff320b3ffa1dbc0b674
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Sat Nov 20 12:41:24 2021 +1100

    Revert "Revert "File upload dropzone and blobservice.""

commit b716ce321b694dd35c58022585c4b6ee7061a359
Merge: 60fb5a5 4fa1b01
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Sat Nov 20 12:40:39 2021 +1100

    Merge pull request #63 from RMIT-COSC2650-SP3-2021-Team-3/revert-54-file-upload-chat
    
    Revert "File upload dropzone and blobservice."

commit 4fa1b010be4e16bcbaa384e62ad2f7b65e16fdf7
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Sat Nov 20 12:39:37 2021 +1100

    Revert "File upload dropzone and blobservice."

commit 60fb5a54da13e75a44b69d45edaf25dfe9fbb621
Merge: 5961ec8 3703779
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Sat Nov 20 12:18:16 2021 +1100

    Merge pull request #54 from RMIT-COSC2650-SP3-2021-Team-3/file-upload-chat
    
    File upload dropzone and blobservice.

commit 37037796fa879121493ae553ed4d74a9a037a63e
Merge: f3e1672 5961ec8
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Sat Nov 20 12:17:14 2021 +1100

    Merge branch 'master' into file-upload-chat

commit 5961ec8103b9011f8a1104b5d76666e65528607a
Merge: 1fccc09 6897d54
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Fri Nov 19 22:33:47 2021 +1100

    Merge pull request #61 from RMIT-COSC2650-SP3-2021-Team-3/channels-notifications
    
    Disable channels for an admin/owner which they aren't invited to

commit 6897d548608f3b76f7721d99827a67541ab37437
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 18 19:46:58 2021 +0000

    Disable channels for an admin/owner which they aren't invited to

commit 4cdfc83207e6b1b44b79b8230b4a66b9953c5e59
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 18 15:25:54 2021 +0000

    User the new snack bar notification instead of alert for channel updates

commit 1fccc0961a4216a13e1c290a3c1375fefff3fc47
Merge: 984d8e8 68d6da6
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Fri Nov 19 19:23:05 2021 +1100

    Merge pull request #60 from RMIT-COSC2650-SP3-2021-Team-3/show-avatar
    
    Correctly show user avatar when one exists on server user management

commit 984d8e8a9f85d429d116a2e442f3a73b21354a30
Merge: 53d1d26 5e84cb7
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 19 13:27:23 2021 +1100

    Merge pull request #62 from RMIT-COSC2650-SP3-2021-Team-3/local-preview-restyle
    
    Centered video test horizontally

commit 5e84cb720b23792bce026e5ab00f22985f7db4e6
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 19 13:26:41 2021 +1100

    Centered video test horizontally

commit 53d1d2654b9b2a9e703f4cd2b9d4664436ff608e
Merge: 6b8822b 69a8f3b
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 19 13:13:15 2021 +1100

    Merge pull request #58 from RMIT-COSC2650-SP3-2021-Team-3/no-remote-video-for-group-caller-bugfix
    
    Now loads remote participant video

commit 6b8822b21df9cb677d257e87cff7eb8f98a07ab3
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Fri Nov 19 09:24:02 2021 +1100

    fix issue where username is undefined

commit 68d6da6def3ef1fcb7c79a414e227406c08e19ec
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 18 14:51:32 2021 +0000

    Correctly show user avatar when one exists on server user management

commit 1c63a668868e59330dad185539e2842ffae718ac
Merge: 5d8657a 3945d09
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 18 15:01:04 2021 +0100

    Merge pull request #59 from RMIT-COSC2650-SP3-2021-Team-3/notifications
    
    Notifications

commit 3945d097f9b4e163c6ba9f18dbec729a35e52082
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Thu Nov 18 16:52:21 2021 +1100

    Notification for blank channel name, group updated to channel

commit da9b68c3e5127fa38880c7c9f657165ab896e965
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Thu Nov 18 14:17:15 2021 +1100

    Changed text on new item buttons

commit 5677db052abc4c7caa431660d90f4fe496663c78
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Thu Nov 18 14:10:41 2021 +1100

    Updated edit and delete buttons on kanban to icons

commit cab35645c99a1af6aa4e4dded0366cc94dded818
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Wed Nov 17 17:04:01 2021 +1100

    Added snackbar notification structure to login and add user to teams

commit 5d8657a676493ee679864fec9429022c0382ea02
Merge: fe48067 9e483cd
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 18 14:52:56 2021 +0100

    Merge pull request #57 from RMIT-COSC2650-SP3-2021-Team-3/removed-call-button-from-channel-list
    
    Removed call buttons from channel list

commit fe48067c0b780d69036cab2b21a82ac54fef64a6
Merge: ceaf876 51edb2f
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 18 14:51:58 2021 +0100

    Merge pull request #56 from RMIT-COSC2650-SP3-2021-Team-3/rerender-local-preview-bugfix
    
    Bugfix

commit ceaf876cfccb61e9163ec219b76b1d654ef422d0
Merge: 523a8a5 1d34c06
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 18 14:47:49 2021 +0100

    Merge pull request #55 from RMIT-COSC2650-SP3-2021-Team-3/addToChannelUpdateUi
    
    Add to channel update UI

commit 1d34c06764c143df3b059febbe5916eb3fbfac9e
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 18 13:18:55 2021 +0000

    Fix initialising chat inner component and out of order operations

commit 57ed9f670929e9cf6060509a9fe7ed47d00377b3
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Thu Nov 18 20:08:22 2021 +1100

    fix bug where channel shows the same set of messages

commit 69a8f3b4a8ba6d9b395b27d1d6a576dfdac9bf44
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 18 16:00:05 2021 +1100

    Now loads remote participant video
    
    - Also adjusted the endCall method to fix a separate bug that freezes app when you try to end a call

commit 9e483cd87e24d187b8d229120cd65f4d76a50ac8
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 18 15:28:25 2021 +1100

    Removed call buttons from channel list

commit 51edb2f846062705c62fdd8f5009abcb2fc03511
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 18 11:06:07 2021 +1100

    Bugfix
    
    - Can now test local preview more than once
    - Removed vid test button so it instead renders video whenever you select an available video source
    - Shrunk the video size so the bottom buttons fit in the page without having to scroll

commit 523a8a52be511acb75fbc3b9b6c32369dbe00bc1
Merge: 84c9a9c 0701562
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 18 10:49:32 2021 +1100

    Merge pull request #53 from RMIT-COSC2650-SP3-2021-Team-3/source-unavailable-bugfix
    
    Source unavailable bugfix for video. Implemented for caller, callee and local preview

commit e69fa7ded6f8cfd94fbbc73c9d92dd84bba177f2
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Thu Nov 18 10:11:59 2021 +1100

    add ability to update UI in real-time when a user is removed from a channel

commit 398860bbc2f2920d1528315e4aad0bd81ca336b9
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Thu Nov 18 09:05:42 2021 +1100

    add ability for UI to update in real-time when user is added to a channel

commit c2e80fb467a2bb46e540f5bf16219785f9a8fc83
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Thu Nov 18 08:28:49 2021 +1100

    remove channel scroll artifact

commit f3e1672d41514389bf0fba4c7d966b6ab3da9ec4
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Thu Nov 18 07:14:05 2021 +1100

    File upload dropzone and blobservice.

commit 84c9a9cce28f9c3f37e453000cfa747f963b6095
Merge: 0abcdaf cddc1b2
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Wed Nov 17 17:38:36 2021 +0100

    Merge pull request #52 from RMIT-COSC2650-SP3-2021-Team-3/remove-participant
    
    Remove participant

commit cddc1b2683b8ceceedef86aa1a6250d2176a3c97
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Mon Nov 15 12:51:11 2021 +1100

    added ability to remove user from chat thread and channel

commit 1272a3b6119d1d5aa3130d2e4a6af0b9edba314b
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Fri Nov 12 12:55:50 2021 +1100

    save progress

commit 7119aca512022e5725a9af8700710d0c8d8bc990
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Mon Nov 15 12:05:10 2021 +1100

    remove duplicate code

commit 9352d097d306b447d3d97d5889d5b9149dd8fb38
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Mon Nov 15 12:08:34 2021 +1100

    rebase again?:

commit cdcd22c7afecd636709f8f32f1c66f374cb0e329
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Mon Nov 15 11:57:20 2021 +1100

    rebase changes

commit 07015625edc2e96e5f66dd536e20761aac3eaee4
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 17 18:05:04 2021 +1100

    Added Unavailable source handling

commit 40bb683402af4f1f2a2853ffc2c2a2b4a35a4e8f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 17 18:04:46 2021 +1100

    Added Unavailable source handling

commit edb1d38b3f20e7ee50b45e28bca9a89760c648f7
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 17 18:04:08 2021 +1100

    Added handling of unavailable video
    
    - Also added the allowance of no camera on call join

commit 52e20ea526de65afb3118d33169df56646cb1c04
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 17 18:03:13 2021 +1100

    Add files via upload

commit 0abcdafb2f0483318b2870ef8c1b5de59b89ed6e
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Nov 15 08:54:27 2021 +0000

    Properly clear any app state stored in memory when logging out

commit b4b7fa0a71a4bfd2743b2403471c95707466f4ef
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sun Nov 14 19:49:50 2021 +0000

    Fix server user management

commit add0beed9f09ac50a0556d55b4265fa6e674ce70
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Sun Nov 14 20:45:53 2021 +1100

    Patch user admin menu

commit eef85d3c9d5a33c0b8df83a43cb1d95af7129d6c
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Sun Nov 14 11:03:33 2021 +1100

    add resource cleanup for chat-inner component on destroy

commit 142e04676d09dfcf933ddb08fa1e3a70c3b4e586
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 16:51:01 2021 +0000

    Add a section in the README for coding conventions

commit bfcd9a80175957cf3dccbf0cc8690a2e61f73ca1
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 16:45:31 2021 +0000

    Add README instructions on running the unit tests

commit 718ccd879d1794317ddffb76f1cc65536f819a54
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 16:39:04 2021 +0000

    Add additional instructions on where to find backend deploy steps

commit de8f0b76d76338bba8332a151f53ea5a7cc90edc
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 15:54:26 2021 +0000

    Add README and related documentation (inc. licensing)

commit 5dd596677bdb24daa2fb4a69af77c22baf73642e
Merge: f9851e8 f14c423
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 14:24:00 2021 +0100

    Merge pull request #41 from RMIT-COSC2650-SP3-2021-Team-3/add-chat-messages-to-database
    
    Add chat messages to database

commit f14c423f0a299e1121bb2c81c309e6147403f997
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 13:18:51 2021 +0000

    Refactor storing posts in DB to work with refactored API (plus cleanup)

commit 6dc7f53db96406ae2499398c83e0414a6a1f7306
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Wed Nov 3 09:16:48 2021 +1100

    waiting for backend to support the frontend

commit 738aeea80f2f7b5a58697d4f3c5aa6f564430396
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Tue Nov 2 15:59:12 2021 +1100

    now able to add post to database but with a hard coded conversation id

commit f9851e8042c772020c18a4ea8c8230e80bdce6aa
Merge: a25f309 0dd687f
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 13:32:56 2021 +0100

    Merge pull request #38 from RMIT-COSC2650-SP3-2021-Team-3/kanban
    
    Kanban page

commit 0dd687f7ac6264a91e827be90adaba452e5ed436
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 12:29:04 2021 +0000

    Hopeful fix for the drag and drop update issues

commit a25f3094e5e6de5cb920897d3f5afbb3671013db
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 11:39:37 2021 +0000

    Bump expiry of SAS token

commit 49cc1b43ca167b52b5183f855afaf54e27c2f117
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 11:34:31 2021 +0000

    Fix updating avatar in profile edit page

commit e015d0775778db2eb5ba179aa2728ca2d9585137
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 10:39:57 2021 +0000

    Fix reloading Kanban board after adding a new item

commit 9a5094d298641505393897c40e0990487955b947
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Thu Nov 11 22:46:19 2021 +1100

    Used modulus to find correct cdk-drop list number

commit cfa809953c481224603cc38b261ffcfaff5619e0
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Thu Nov 11 22:45:36 2021 +1100

    Updated lists to correct ones. Refresh list after new item creation to solve missing id issue. Find modulus of cdk list name to return correct lists.

commit 00e5901e38fc0b8c117fc3766f99a15f0cfa03a1
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Mon Nov 8 12:33:18 2021 +1100

    CSS Styling including responsive styling

commit 16e71a39af4916fd7d03723e898861d9a48b6421
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Mon Nov 8 12:08:59 2021 +1100

    CSS Styling for desktop

commit e0d09865bd5d2735159eb2d5612a7ca8e149313f
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sun Nov 7 23:07:49 2021 +1100

    Added form validation for names over 20 characters. Added delete confirmation.

commit 0e1186fa5c5801568a8eb756a14e470d28486f6d
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sun Nov 7 17:50:53 2021 +1100

    Edit item implemented

commit f9a8f00315c7ea26eb05d572469b0d0114e75df8
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sun Nov 7 15:03:26 2021 +1100

    Changes to property names to match backend

commit d6ab60ecc4cde288932db6abc8ed3c3befd255ea
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sun Nov 7 12:32:08 2021 +1100

    Added functionality to update positioning and list

commit e9a3f9d7265216d19f4a2bf2accdf0a5d2c2f963
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Thu Nov 4 18:37:20 2021 +1100

    Added service to connect to API once built. Updated component to hold entire item object rather than just text

commit fbae6c893ea551188234f513d32bf6cd42a363c7
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Wed Nov 3 15:43:04 2021 +1100

    Changes to buttons

commit 151886c677858e9be949a805c1fa793a2f5d166c
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Mon Nov 1 14:55:31 2021 +1100

    Added extra dummy data

commit 79c53b9b79b2bed8ae8a6044d30138412ce0f2b8
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sun Oct 31 23:08:34 2021 +1100

    Simplified add function and added delete function. Local no db

commit 5d68af712928d80cff00ef928eaed109b330452a
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sun Oct 31 22:22:41 2021 +1100

    Added kanban component

commit 9ffa2172f49006b47f02417e43b8d601770d303b
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sun Oct 31 22:22:10 2021 +1100

    Added dialogue to add item to kanban

commit 9ce78e3d3f78d3e4f61535f1087d3d3be1e2c2ed
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Thu Oct 28 14:14:11 2021 +1100

    Created component for Kanban board

commit b65495367dfa3ec3461fa28c7c6ab70f18dec999
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 10:03:11 2021 +0000

    Disable sign in button when username and/or password are blank

commit 3511b688af8b6f934305fe1b8ef1294fd381dba7
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 09:48:26 2021 +0000

    Fix SSO

commit 29946b5c583c9708d31ba3445ca936bfd5bb50bb
Merge: de7cab5 2df9a9c
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 10:42:05 2021 +0100

    Merge pull request #49 from RMIT-COSC2650-SP3-2021-Team-3/add-in-friend-call-button
    
    Add in friend call button

commit 2df9a9cab1fdfef23fb7fbc52a5281c2e2cfe612
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 13:49:11 2021 +1100

    Added friend acs id and call type flag

commit df3f867edea887e3cbc21b2c6fb1070df53ed275
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 13:46:30 2021 +1100

    Added flag
    
    - Call client is now informed that the selected channel call would be a group call, not a 1-on-1 call

commit 69069231f44c39640ff984aed4bfe7ffb922a50b
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 13:41:59 2021 +1100

    Added in flags
    
    - Call client service learns of friend acs id and whether it is a friend call or not

commit 2e3d41f4a6e8add6cd1671f5373c5914534dbd07
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 13:40:39 2021 +1100

    Added in friend call conditional

commit de7cab528f17aed8d2ad4827191b1c112e195d25
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Nov 12 09:19:20 2021 +0000

    Fix fetching servers on dashboard

commit 9f479a0bc679b067fa3fd6f17099a809a5742bb3
Merge: 382512d b7ee3de
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Fri Nov 12 18:50:08 2021 +1100

    Merge pull request #51 from RMIT-COSC2650-SP3-2021-Team-3/revert-50-revert-31-server-user-management
    
    Fixed syntax errors introduced in attempted merge of code

commit b7ee3de98dc06d7ee56a9905183b13881b1729e3
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Fri Nov 12 18:49:12 2021 +1100

    Update server.component.ts
    
    Syntax changes due to errant closing braces not picked up on previous merge

commit 4ba9c14a25698141a5205f0f9f1adafad20db4a5
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Fri Nov 12 18:44:49 2021 +1100

    Revert "Revert "Give server user management a simply UI to change user roles""

commit 382512d1e9738fc12bd30106df98351644d5f8f5
Merge: 0236b93 e7440e4
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Fri Nov 12 18:28:38 2021 +1100

    Merge pull request #50 from RMIT-COSC2650-SP3-2021-Team-3/revert-31-server-user-management
    
    Revert "Give server user management a simply UI to change user roles"

commit e7440e493d3aadd76916bc00f5d9170f64a5f147
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Fri Nov 12 18:24:54 2021 +1100

    Revert "Give server user management a simply UI to change user roles"

commit 0236b9365d7148565aa0bd5b7b49e26e94314cf1
Merge: baf4416 a2b22b2
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Fri Nov 12 18:23:04 2021 +1100

    Merge pull request #31 from RMIT-COSC2650-SP3-2021-Team-3/server-user-management
    
    Give server user management a simply UI to change user roles

commit a2b22b2fed99d8d501b6744d265ceec29958ef36
Merge: 7a12ed2 baf4416
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Fri Nov 12 18:12:27 2021 +1100

    Merge branch 'master' into server-user-management

commit baf4416a045adbdad9014954e31ccb5a14178fb1
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Fri Nov 12 15:09:26 2021 +1100

    add channelId to call-client.service.ts to fix compile error

commit 83226af00226079283b5aa271038ff87c26dc58d
Merge: 5c2e0cf 77b9baf
Author: Duc Tran <55226475+s3500659@users.noreply.github.com>
Date:   Fri Nov 12 14:54:38 2021 +1100

    Merge pull request #45 from RMIT-COSC2650-SP3-2021-Team-3/fix-loading-acs
    
    Fix the order in which ACS loads to avoid errors

commit 77b9bafce66a50de44624d4fd3b3fab94dbcdc2d
Merge: 5b8b4dc 5c2e0cf
Author: Duc Tran <55226475+s3500659@users.noreply.github.com>
Date:   Fri Nov 12 14:54:20 2021 +1100

    Merge branch 'master' into fix-loading-acs

commit 5c2e0cfa1acf2ca9c7a2baf3035b14982919fbee
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 13:15:55 2021 +1100

    Some endpoints weren't using environment url base

commit 032c58e50d015edc604f602bf4ea956e2b213cda
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 12:08:25 2021 +1100

    Added in the current Contacts button

commit 55214bd395bc8bd4e1020c6ca4fe8d6942ee6667
Merge: 1225d61 e23af5f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 11:38:38 2021 +1100

    Merge pull request #48 from RMIT-COSC2650-SP3-2021-Team-3/channel-service-bugfix
    
    Channel service bugfix

commit e23af5f05d48ea12763423e0a21cf5122876f46a
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 11:33:31 2021 +1100

    Update squabble-channel.service.ts

commit 7f12f4e4f02bbe67b094e3401e28cf944afbd54e
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 11:32:52 2021 +1100

    Shouldn't be here

commit 5f64dda9918a022fe2e68a1ac488028faad547d2
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 11:32:40 2021 +1100

    Shouldn't be here

commit 398bbe0c9ddec53f1f42e732c1509cd219e076ba
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 11:31:59 2021 +1100

    Changed the channel service used

commit 7c5468a9f9fc7e254a8d5d168631f4014bb0eeee
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 11:31:38 2021 +1100

    Changed the channel service used

commit 75f688ca88235e3dc1dcbc21ac90c2196a3e172e
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 11:31:19 2021 +1100

    Changed the channel service used

commit e5051cc3c4e6a34991b0df503cb17518a96247d0
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 11:30:51 2021 +1100

    Changed the channel service used

commit 85bfbef333edfdf4ff03a9ef98b10aee0ddb5a8f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 11:30:09 2021 +1100

    This has been replaced by the other channel serv

commit 12aee33e6d7cedb52b4b148c9df26e4ea9a1d4d4
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 11:28:42 2021 +1100

    Add files via upload

commit 1225d617a53528313cc85a0675d5dccea0f677c3
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 11:04:08 2021 +1100

    Added in missing methods to service

commit b673625cf2a4085e5853c36e5a029d3caf30a643
Merge: b92acde 8dbad65
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 10:56:31 2021 +1100

    Merge pull request #47 from RMIT-COSC2650-SP3-2021-Team-3/channel-call-test
    
    Added channel call to live version

commit 8dbad65d1626844b2d35afecbb59668a4a079a41
Merge: d1cd85b b92acde
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 10:53:08 2021 +1100

    Merge branch 'master' into channel-call-test

commit d1cd85bd3cdad1701af4313dacd4e72bb9953805
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 10:32:23 2021 +1100

    Temporary workaround for naming inconsistency
    
    - Renmove SquabbleChannelService after references to it use ChannelService instead

commit 8e9eee54464a37bd52c24cce42b1ae919c98439f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 10:26:12 2021 +1100

    Add in channel service changes from main

commit b92acdea7a9d75562742609a5898a76cbee515e5
Merge: f42c1de fe4f8d2
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 10:17:51 2021 +1100

    Merge pull request #32 from RMIT-COSC2650-SP3-2021-Team-3/individual-conversations
    
    Individual conversations

commit fe4f8d2b417327fb3a5d8c62f30ce310b38b4140
Merge: 69ccd47 f42c1de
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Nov 12 10:12:44 2021 +1100

    Merge branch 'master' into individual-conversations

commit 5b8b4dcef68be172ff884cf23821a3a7b7ee7d89
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 11 16:14:56 2021 +0000

    Fix the order in which ACS loads to avoid errors

commit f42c1de38d3313d92da353ec3f7c3af23543c5d5
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 11 15:47:04 2021 +0000

    Better handling of ignoring first time onChange events in chat inner

commit c71133d7cc81f642c84eab2fbfe09da38654fd39
Merge: 0c88e67 22da45c
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 11 15:22:21 2021 +0100

    Merge pull request #43 from RMIT-COSC2650-SP3-2021-Team-3/bugFix-send-receive-chat
    
    fix chat null input element issue, fix duplication of messages on rec…

commit 0c88e6783f42dc44cea127c470286092e7808ba2
Merge: 5ca2397 26a2aa9
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 11 13:56:36 2021 +0100

    Merge pull request #40 from RMIT-COSC2650-SP3-2021-Team-3/authGuard
    
    Added AuthGuard & Logout

commit 26a2aa9a89abd4a0d9145b02ff0ce97c16ad4bf1
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 11 12:54:51 2021 +0000

    Check for accessToken every time we check if user is authenticated

commit 69ccd479f234779ad416486765d57adb8d14ecbf
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 11 11:51:35 2021 +0000

    Fix order of loading operations in chat inner component

commit cca69d66c71adf55efc5765914ca2d4c79563554
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 20:43:30 2021 +1100

    Fixed compile error from unresolved conflicts

commit 8d5ac2975c71538da998b96cd7f071668a4500bb
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 20:42:51 2021 +1100

    Fixed compile error from unresolved conflicts

commit 4e992bc649ec951d1cc33ad1e75b1275219202dd
Merge: 5ca2397 0d27d2f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 20:32:43 2021 +1100

    Merge pull request #44 from RMIT-COSC2650-SP3-2021-Team-3/switch-to-channel-call
    
    Switch to channel call

commit 0d27d2fa3fe512038e132573013cead307474724
Merge: d1407e2 5ca2397
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 20:31:59 2021 +1100

    Merge branch 'channel-call-test' into switch-to-channel-call

commit d1407e2c432d20d926c43810a5555d493b11dc20
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 20:14:10 2021 +1100

    Add files via upload

commit ec90f2bf9f69765ea1421c5d42ced092be591be3
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 20:13:29 2021 +1100

    Add files via upload

commit 4a1a0a5a068300de1f0677321ff307dd4603db90
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 20:12:58 2021 +1100

    Add files via upload

commit f0ea0e2d7d298580246a9373d750f2f343a7d1fb
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 20:12:37 2021 +1100

    Add files via upload

commit 18b79e42123813a0584e78948b59cad2e0cac0d3
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 20:11:55 2021 +1100

    Add files via upload

commit 3c0bbbc255b8b47f7c6d4e5bad56f5d3ed745ec4
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 20:10:36 2021 +1100

    Add files via upload

commit ad3c2086fa1a4014246ba0a306f8c0422cdd7fc9
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 20:09:42 2021 +1100

    Add files via upload

commit 82ca4dd30abc1c5b42716502893a521ee44ba837
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 20:09:13 2021 +1100

    Add files via upload

commit 0659dc7d01eb667e7755c4931d810500dadddb20
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 20:08:51 2021 +1100

    Fixed caller display name in notification popup

commit 5dbb853948d3b949ae4ad727c725c42abb6d7c1b
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 20:07:45 2021 +1100

    Add files via upload

commit ad048675ac478e76f811e73e7aaa0e10561a0a3c
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 20:03:33 2021 +1100

    Updated view for add/kick caller side

commit e67923aadf74014c8e04cfe9f61ce4fec64f9337
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 19:58:55 2021 +1100

    Add files via upload

commit b75b809802451793cb336730cd8ce1433942a225
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 19:57:40 2021 +1100

    Add files via upload

commit 1d952553e459c162787b79eeb1212dc1932ed002
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 19:57:15 2021 +1100

    Add files via upload

commit 22da45ca73c1c3f661e61adc8b22d4b27b30a0b6
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Thu Nov 11 12:50:00 2021 +1100

    display correct initial for chat users

commit b051ce078da2b07846c8250d9497d9056d8c6062
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Thu Nov 11 12:15:29 2021 +1100

    remove console.log()

commit e2d8ad4271f9eec76a03dc0ce439be6bf8c4d718
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Thu Nov 11 12:10:45 2021 +1100

    fix issue with messages and typing notification being displayed globally

commit d3198f036ec1fe0bba2b004da62dcaec53d0c008
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Thu Nov 11 11:47:18 2021 +1100

    minor code refactor

commit d6e31e76484e1c68a377aeab209238aec572a9c1
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 11:40:46 2021 +1100

    Functional add/kick
    
    - Slightly misleading select list content at times (callee's may not have joined yet, but are treated as  connected)
    - The ngIf seems to work for me in blocking members from using it.

commit 97bc2be0faebf9c259dc50543c4fb47a5928234d
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 11:38:40 2021 +1100

    Updated adding/kicking
    
    - Still needs a way to find out the channel id that is associated with the call

commit 32885627d29d8af06868804ddd031c52de9b4121
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 11 11:37:21 2021 +1100

    Removed unused call events

commit 574351e22e2b865a0ac4b64aa674fa91d9c61578
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Thu Nov 11 11:22:12 2021 +1100

    fix chat null input element issue, fix duplication of messages on receiver end

commit 828269287fdc1018b2c8e184546a42b6ff3e5e3d
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Wed Nov 10 22:49:54 2021 +0000

    Fix broken test

commit 45f6d730600846314c5031b6e534f6beb86ab97c
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Nov 8 13:06:38 2021 +0000

    Fixes from rebase

commit f61b365a97b0a56c64c3b2337cae5834bdaf79fc
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Nov 8 12:37:07 2021 +0000

    Add support for one-to-one conversations with contacts

commit 5ca239744899c70e49167ddf2f2bd51a332f5399
Merge: 096e488 586194c
Author: Duc Tran <55226475+s3500659@users.noreply.github.com>
Date:   Thu Nov 11 09:51:52 2021 +1100

    Merge pull request #39 from RMIT-COSC2650-SP3-2021-Team-3/fix-channel-selection
    
    Fix selecting channels in the server view

commit 86a74a6ae947a2aace52fdf794f0cc7705a6d3a8
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Nov 4 15:26:39 2021 +0000

    Refactor friendships/contacts with an approval step before being friends

commit 47960ff88b1618fb2cc9428207867ff2ad7a8bcf
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Mon Nov 1 16:46:21 2021 +1100

    Styling to component

commit 4e836fddcad3debd668c259b10cfae2c0b98f056
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sun Oct 31 18:20:44 2021 +1100

    Added extra data displayed and basic styling

commit 110703d9dc8ffcdf235c95f3cd47f371cd6c7363
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sun Oct 31 17:01:48 2021 +1100

    Updated to real names instead of username

commit ee1da490835a6f678d2121db0fb8d33b10718717
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sun Oct 31 16:59:13 2021 +1100

    Added token decoding to fetch correct logged in userid

commit 4e5d6f7ddf83a4ea76341b6daf6308b834bebda6
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sun Oct 31 16:57:31 2021 +1100

    Added token decoding to fetch correct logged in user id

commit 1d44978fc76090b8c52bf4c21000208903ea2797
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 28 17:30:55 2021 +0100

    Refactor `ContactsComponent` to work with new API response

commit 8298e146a03edf218f5db7637306c0329a81a9ae
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Thu Oct 28 18:24:22 2021 +1100

    Implemented close and error return message on add friend dialogue

commit 31e1dab2c6f7805eadbf6a6f1b7cbf87d704796b
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Thu Oct 28 18:20:21 2021 +1100

    Added dialogue to add friend

commit 1a7e02e92985719fc722a302bc73a9d4bb673462
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Thu Oct 28 16:45:42 2021 +1100

    Added foundation for displaying friends list

commit 5455e0d491ba2e93c662352476c36f80f90cc77a
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Thu Oct 28 13:54:31 2021 +1100

    Basics for new contacts component individual conversations

commit 9a8aba3c0a117a4b68a9c1b5f24640d623f51ad6
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 19:13:14 2021 +1100

    Added null type to incomingCall

commit cf290ab85dc3de7b1e3169d88acdcd3fadc577b7
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 19:09:20 2021 +1100

    Add files via upload

commit cabc5cf53a7bc850625e7bbae89c73a37d7957e5
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 19:08:55 2021 +1100

    Changed caller display name for notification

commit b6424d5fd712723bb3b54075e7ec470ddbdc0f05
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 19:07:58 2021 +1100

    Added in rough add/kick participant code
    
    - Kicking works
    - Adding doesn't

commit a976dd62550fee4c2a46ad5bfd3badaccfe6227e
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 19:06:28 2021 +1100

    Changed properties to lower-case

commit 96e52a20278a534fe1c02c4416a6b0a56b10b171
Merge: 1d482c2 096e488
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 17:57:08 2021 +1100

    Merge branch 'master' into authGuard

commit 096e488cc27e45360944eabbad72587a489a84bb
Merge: 236183d ec58616
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Wed Nov 10 15:44:10 2021 +1100

    Merge branch 'master' of https://github.com/RMIT-COSC2650-SP3-2021-Team-3/Squabble-Client

commit 236183de72a5f24ebafb78ce47c56fe627a6cdac
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Wed Nov 10 15:40:29 2021 +1100

    Rotating chevron

commit 4427c8cf6bff69053383f7dcb0809e7c917ba285
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 14:29:22 2021 +1100

    Adjusted emitSelectedChannel method

commit a14264a82edfe96572a5696bfc12d03321a61a20
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 14:28:36 2021 +1100

    Add files via upload

commit 57a9f66a1959175f5e502be4ee445513c280840c
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 14:27:17 2021 +1100

    Reimplemented channel call

commit efaafb2195ab49acc5394c748ca930491ac838d7
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 14:26:21 2021 +1100

    Add files via upload

commit e22c134494969140f4d67c7b41c8cc3a6502444f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 14:24:43 2021 +1100

    Updated channel member info dto

commit ec586169387e41ee89f8122a62e8778e5e1d4b5b
Merge: d641756 cbe17de
Author: Duc Tran <55226475+s3500659@users.noreply.github.com>
Date:   Wed Nov 10 12:07:38 2021 +1100

    Merge pull request #42 from RMIT-COSC2650-SP3-2021-Team-3/fix-login-infinite-loop
    
    fix login infinite loop

commit 08516928e41fe53d8e9f6774c700d8519a540f02
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 11:44:19 2021 +1100

    Friends list replaced by friend/channel

commit 1a4bd3f5770aada28c96f1d190b8ba95b984e480
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 11:43:47 2021 +1100

    Friends list replaced by friend/channel

commit cbe17de28a8a965ca8d628f660f019ae0a3ed1f6
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Wed Nov 10 11:42:51 2021 +1100

    fix login infinite loop

commit 561a4189aa916e893e37c15ed3cc4e5d6a6c9718
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 11:42:39 2021 +1100

    Add files via upload

commit 4063ee30e0b44ecc6bdb55bda0321e70251fc8f0
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 11:41:26 2021 +1100

    Removed call button from sidebar

commit 9bd2a46b2f181b0e6fe8bc4cbd2c9f87c01d3723
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 11:40:39 2021 +1100

    Add files via upload

commit 64370e02ac6f1456e497c2bfda36ca795e09947e
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 11:40:10 2021 +1100

    Add files via upload

commit 82e67e2011b2d47968054acca93e931bb4d13d3b
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 10 11:36:54 2021 +1100

    Readded profile picture icon

commit 586194cb29b86e7d61169a47f9aacb68315cf656
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Nov 8 13:48:08 2021 +0000

    Fix selecting channels in the server view

commit d641756ffe28fe19ffc9607c5e3d2937969c3c72
Merge: b82d8d7 fb7174b
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Tue Nov 9 16:35:20 2021 +0100

    Merge pull request #36 from RMIT-COSC2650-SP3-2021-Team-3/show-chat-participants
    
    Show chat participants

commit fb7174bfc6aa62d3de1d91e4e2d9c6c51be29213
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Tue Nov 9 11:48:28 2021 +1100

    add ability to show participants in a chat thread

commit f473c3ed37f5cbaf8edcc0c0f3df23c9f847ebf7
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Wed Nov 3 16:56:28 2021 +1100

    add ability to show all participants of a chat thread

commit 087d35bde785f14514bc97eedffada90c639e7f8
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Tue Nov 2 13:39:33 2021 +1100

    add typing notification functionality

commit b82d8d7f1929677cfb277dec6506b8ff6415ece0
Merge: 1964e78 9eed3f5
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Tue Nov 9 16:17:07 2021 +0100

    Merge pull request #33 from RMIT-COSC2650-SP3-2021-Team-3/typing-notification
    
    add typing notification functionality

commit 9eed3f5918f1b117cf4bb5b1b88a4db4fb44aad9
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Mon Nov 8 14:35:25 2021 +1100

    improve algorithm for displaying chat messages

commit b6ce87331e2f897f9d7fc2152c9bc70fefe4e344
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Fri Nov 5 12:08:14 2021 +1100

    channels window now scrollable

commit 396523ec3b2453c117290473e5c495a7ecf23554
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Fri Nov 5 11:32:32 2021 +1100

    sending a new message now scrolls the message window to the bottom. Typing indicator is now always visible but has stome styling issues

commit 2e4b2f01deddcc0bbe9b0306e6a23fb95ad2d3bc
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Fri Nov 5 10:15:55 2021 +1100

    made message window scroll to the bottom of the page when sending a new message

commit eb2575e55fb99e00068bdc42c1277c599cccf384
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Fri Nov 5 09:45:29 2021 +1100

    add typing notification support for 3+ users

commit 6b52b006b60914af64937fb17d9c2dd446228338
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Thu Nov 4 17:20:32 2021 +1100

    made typing indicator dissapear after 5 seconds

commit a107cfab1c42e331378e0830566a0e0edbbb9a11
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Wed Nov 3 22:13:24 2021 +1100

    Added animated typing and scrollable message window

commit 42404ccd4d5c383a2650528c4b61e6dec483dd56
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Tue Nov 2 13:39:33 2021 +1100

    add typing notification functionality

commit 1d482c22015c05712f99c78f882724ab41bb9282
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Tue Nov 9 23:01:01 2021 +1100

    Added AuthGuard & Logout

commit 5f7587a989bab48d92ecc2f93f530962eccbedd3
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 9 11:11:17 2021 +1100

    Moderate (disabled) changes
    
    - Added in a button to call the channel members

commit 665f4301cd28de12cc329e88fe99d87a5737add6
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 9 11:10:19 2021 +1100

    Moderate changes
    
    - Sets a property in the call client service to the emitted channel's id
    - Template consists of a disabled call button. To be replaced by a button in the inner chat component

commit 55da8341ce0cb5e6cec0803b154d56ff4e811de8
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 9 11:08:07 2021 +1100

    Major restructure
    
    - Added in detailed comments
    - Renamed variables and removed redundancies
    - Implemented a disabled way to call channel members. Just call friends for now from the sidebar
    - Implemented event to end call on leaving page (same for caller file)
    * Some events still serve no purpose

commit 6e7db0778ec3dda478c259cf5ab06c6a21a6e1ea
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 9 11:06:50 2021 +1100

    Major restructure
    
    - Added in detailed comments
    - Renamed variables and removed redundancies
    - Implemented a disabled way to call channel members. Just call friends for now from the sidebar
    
    * Some events still serve no purpose

commit 7957ea2bf3b49c852aed1cbee374c920febe1af3
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 9 11:04:32 2021 +1100

    Added channel service
    
    - Only has a method for getting the channel member's acs ids for now

commit e2cbf809851fbfd150e1da1327c047da18ba3e20
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 9 11:03:26 2021 +1100

    Added channel member info model

commit f68974e8df596a3f4eaaf34af53b887a3dc835b7
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 9 11:02:39 2021 +1100

    Minor changes

commit e208270b9a18ead6b6369b9a5942900e47de577e
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Sun Nov 7 21:22:02 2021 +1100

    UI for Caller & Notification

commit c9f621f3454bdd7d327a4a08d7b3a435aad4a0a1
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 4 16:22:58 2021 +1100

    Replaced by Caller/Callee components

commit 1fd86592617eea115385cdcb64f7e76ccbb7da7f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 4 16:22:47 2021 +1100

    Replaced by Caller/Callee components

commit 7d0b1dc228b051ddad13bda8c49919c2e857a823
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 4 16:22:34 2021 +1100

    Replaced by Caller/Callee components

commit e8339089f52fa0f15f651a8091949cebf4629272
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 4 16:21:41 2021 +1100

    Call component restructure
    
    Caller and callee components now cover all call types for a caller and callee

commit f48254abbb3b96fe5b26f235cb9004b10ba995d3
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 4 16:19:53 2021 +1100

    Call components condensement

commit 42d846111341ecb69752ba9b4210f80ddfe5a3b0
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 4 16:19:08 2021 +1100

    Add files via upload

commit d8e593370392d529cbd9d428d9876eabfc6a2eb8
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 4 16:18:39 2021 +1100

    Call components name change

commit 1964e789cf947484b4a19fefcccd9421c850f730
Merge: 8d15627 c3edc6c
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 4 13:04:31 2021 +1100

    Merge pull request #37 from RMIT-COSC2650-SP3-2021-Team-3/acs-call-notification-handling
    
    Acs call notification handling

commit c3edc6c708ddf3f6fa5295a35bca73fbc0a43655
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 4 10:27:33 2021 +1100

    Add files via upload

commit 6f3f19b4bff9f9c79c04c4befa6d921e01651380
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 4 10:27:07 2021 +1100

    Add files via upload

commit 8e4fc995d8a79de94367272dabccbb876bb89c2d
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 4 10:26:43 2021 +1100

    Add files via upload

commit 5c31d86e4ec652206e236904c408f4693378e867
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 4 10:25:52 2021 +1100

    Add files via upload

commit 43b0027a2f0113942003ad79801beabd13e7e576
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 4 10:25:27 2021 +1100

    Add files via upload

commit 3a009738d016d8e7e98a6075d7d6c929b0fdb716
Merge: 981b16d 8d15627
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Nov 4 10:12:17 2021 +1100

    Merge branch 'master' into acs-call-notification-handling

commit 981b16dfac9c18e5277922d616f9bf1673d60788
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 3 15:29:21 2021 +1100

    Add files via upload

commit 85e38d315b9a1fda0d09b53516232d5e32ef7233
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 3 15:28:25 2021 +1100

    Add files via upload

commit 5952e1ba70db2770f566274ab1cfd47fc072e248
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 3 15:09:38 2021 +1100

    Add files via upload

commit 4b8ce2281bdc24cd9e2052d1a5a7c6b8f4f4f73f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 3 14:38:05 2021 +1100

    Removed unused code

commit 2ff01e2e8a2d061cbc96971d353622c2bc0de3ca
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 3 14:36:51 2021 +1100

    Working view for local/remote video streams

commit d39a2c75a2b8b9a443806f180be6a0b9035d68bc
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 3 14:36:25 2021 +1100

    Working view for local/remote video streams

commit 8f069bdf24582dbb9d9767d5fce0d51d33909c1e
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Nov 3 14:34:25 2021 +1100

    Add files via upload

commit 7a12ed2d91ed99e1f74b8f3768d4fe665b5a07fc
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Tue Nov 2 22:28:03 2021 +1100

    Update manage-server-users-dialog.component.html

commit 2f105ede6c48f710dcca1bd174283e80b73ba919
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Tue Nov 2 22:19:17 2021 +1100

    Updated Front End For User Admin / Auth Controls

commit 72dd3e44d48747dfec2531f41bd0cc2ed66e1a03
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 2 15:21:33 2021 +1100

    Update squabble-team.service.ts

commit 5f1e514a73846b530bd33e89e159b53a5227f731
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 2 12:15:52 2021 +1100

    Delete voice.module.ts

commit 8b89a8b692a75ec05d3a7206c776e3d1e01247d0
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 2 12:15:45 2021 +1100

    Delete voice-routing.module.ts

commit 01e3ce1ab02ac292b89c1cd20175cda10c0df94a
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 2 12:15:34 2021 +1100

    Delete video.module.ts

commit 26101b70e041c76425ecb90da5a126e1683eacf3
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 2 12:15:22 2021 +1100

    Delete video-routing.module.ts

commit e2526ea225aa96b6301edac7f8562b202ec4f8e9
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 2 12:14:53 2021 +1100

    Add files via upload

commit 612e4eeddf36b88b83b6f8a27f37fbfb0c805455
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 2 12:14:21 2021 +1100

    Add files via upload

commit 655600d3536fcb07560b878433208826b973f3bd
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 2 12:13:48 2021 +1100

    Add files via upload

commit 6d52c035226528717164eba5c3e72f1d386ba565
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 2 12:13:17 2021 +1100

    Add files via upload

commit 69ad181e435687045372dc99a3dbb9bcf281c251
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 2 12:12:52 2021 +1100

    Add files via upload

commit 1412175f54a898ce9f476488779251846c4ea1e9
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 2 12:12:22 2021 +1100

    Add files via upload

commit 303dccfe86ef56e447b9d5291c4a7b2b72523fc6
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 2 12:11:44 2021 +1100

    Add files via upload

commit 3d7bd64651564264ae1695fdb5b0997d9fe9f4a9
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 2 12:11:14 2021 +1100

    Add files via upload

commit bed7c81f8053e9003049158a1aeb696eeda46628
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 2 12:10:28 2021 +1100

    Add files via upload

commit 7d502cba672641ed4f0cf337cc6db3a3272f4d8b
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 2 12:10:06 2021 +1100

    Delete acs-incoming-call.ts

commit baf1257bfc115cd73b595e525589a251f5510e11
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 2 12:09:45 2021 +1100

    Add files via upload

commit b5cce718d735b1970950656a633b5e5b08d5954a
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Nov 2 12:09:01 2021 +1100

    Add files via upload

commit 93d291b95133616a4e87b2a264a6fbc33931358e
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 28 08:25:36 2021 +0100

    Give server user management a simply UI to change user roles

commit 8d15627b325dd4ec2da73549ba0fe8e87ad9d7fb
Merge: fc1da16 1898707
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Sun Oct 31 21:01:22 2021 +1100

    Merge pull request #30 from RMIT-COSC2650-SP3-2021-Team-3/updated-routing
    
    Updated nav and integrated route into header

commit 1898707052873dc037d245692763da2b318e576a
Merge: 4e336c7 fc1da16
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Sun Oct 31 21:01:13 2021 +1100

    Merge branch 'master' into updated-routing

commit 4e336c7e860b9ec233dd7da10e35c8eadbb27a95
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Sun Oct 31 20:57:38 2021 +1100

    Updated nav and integrated route into header

commit fc1da169c7ddaf2f0384fe1d8e036f4f03e0e217
Merge: c551dce 3783262
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Sun Oct 31 20:03:49 2021 +1100

    Merge pull request #29 from RMIT-COSC2650-SP3-2021-Team-3/display-avatar-toolbar
    
    Add support for displaying user avatar in toolbar

commit 378326201709c10f1678d69f9fd06314a3537350
Merge: 21c8ef2 c551dce
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Sun Oct 31 20:00:17 2021 +1100

    Merge branch 'master' into display-avatar-toolbar

commit c7f2a5e0e314609b50e9e866a718092363357f63
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sun Oct 31 18:38:41 2021 +1100

    Ignore this stuff

commit 08fa0434bb7fc9bf1259c98344cb6785c074a924
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sun Oct 31 18:37:42 2021 +1100

    Add files via upload

commit 8845ca389d09263d9a34b2a80b2640018f303863
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sun Oct 31 18:37:16 2021 +1100

    Add files via upload

commit 945d4f53ef9099ef72efbc388076457612dfa1c5
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sun Oct 31 18:36:46 2021 +1100

    Add files via upload

commit b389eed767d6dbc078dcae3ced86649d1520d6e6
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sun Oct 31 18:36:22 2021 +1100

    Add files via upload

commit 4da6dd2007b5b12820aef244340fa7c2c96582c8
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sun Oct 31 18:35:56 2021 +1100

    Add files via upload

commit 6e531f4496bc4be481ebf1f7127f5fa7c221d389
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sun Oct 31 18:35:15 2021 +1100

    Add files via upload

commit b4a313c6cc03fe41cda62af3925e7e6940b36360
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sun Oct 31 18:34:26 2021 +1100

    Add files via upload

commit 703484492296b68ec2e316f006b05003d11e6792
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sun Oct 31 18:33:55 2021 +1100

    Add files via upload

commit 1cdff88ee7c96aa9f3f08a903488db5568df7d98
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sun Oct 31 18:33:13 2021 +1100

    Ignore IncomingCall file

commit 9900788c2fed2af58b9f7aad51e044382bd6d68f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sun Oct 31 18:32:25 2021 +1100

    Add files via upload

commit 21c8ef212225f903a4776badf8eab8080b8a9bd7
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Sun Oct 31 17:04:16 2021 +1100

    Implemented profile-upload capabilities.

commit 010c8663202d92b15ebbfae22955f3b6de3fdabe
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sun Oct 31 16:39:37 2021 +1100

    Add files via upload

commit c551dce737c4563161427c25e236ee5117b7ad35
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Sun Oct 31 08:39:43 2021 +1100

    Front End Component For Profile Avate
    
    - Yet to implement upload functionality.

commit b95c05c034c4abc133fdb38b5707cd84a521c64a
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Oct 29 16:13:19 2021 +0100

    Add support for displaying user avatar in toolbar

commit 17c893fd91f75ddca4ff1362f20319f8715e36c4
Merge: 1a879b9 6b9dbc2
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 15:19:25 2021 +1100

    Merge pull request #28 from RMIT-COSC2650-SP3-2021-Team-3/acs-call-notification-handling
    
    Added global temp call auto-join

commit 6b9dbc203498b6a41a6860aad7b5ec31252cb345
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 15:17:37 2021 +1100

    Expanded site access to call handling

commit 554133c16ece79f61d9d6a585242a265b751b4f2
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 15:16:48 2021 +1100

    added incoming call event temp auto join

commit 1a879b92a0ed30bca24e2950e22521cc56648230
Merge: c18e843 21a3a8b
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 14:15:33 2021 +1100

    Merge pull request #27 from RMIT-COSC2650-SP3-2021-Team-3/call-preview
    
    Call preview + call components restructure + updated FriendInfo client dto

commit 21a3a8b4a2c7795d725d7d0236891ce8efdedf8f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 14:07:54 2021 +1100

    Replaced by voice in one-on-one folder

commit 271ecc65d81bb0b15ab48803f8de5760cbe4694b
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 10:51:20 2021 +1100

    Add files via upload

commit bb701159886eabbe369e1db899d03bae868d3dcd
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 10:31:59 2021 +1100

    Add files via upload

commit a6f5eb986cd5b6c9e21b60bc0a3917ca7ec96256
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 10:31:48 2021 +1100

    Delete app.module.ts

commit d7e4367413d6fa22627128b848ce9885c744a7e9
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 10:31:39 2021 +1100

    Delete app.component.ts

commit 8615d3c368a1eaf3497949f6c71310ab365919bb
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 10:31:27 2021 +1100

    Delete app-routing.module.ts

commit 8dfe3d827fa0ccfce73bff5e901f574bfe73e78e
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 10:28:43 2021 +1100

    Add files via upload

commit fc685a5745c49ffdf581042e2612d115fc5dbf0e
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 10:28:00 2021 +1100

    Delete app.module.ts

commit a2a44e26fff93ab2d051537c50acf0b8d508b9ac
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 10:27:48 2021 +1100

    Delete app-routing.module.ts

commit eee4664ba2777a9ff0f46ee8e254f683ffbc2114
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 10:22:51 2021 +1100

    Add files via upload

commit e77ff436f04629d9d1785c4a89d7da8b3972b787
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 10:16:26 2021 +1100

    This is soon to be replaced with new directories

commit acc6c28d1b7598dc0554340d2ea3634052f88d9b
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 10:15:51 2021 +1100

    Added initial group call progress

commit bbfb3bafd4b29568047a36983741ccaccef8d255
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 10:15:16 2021 +1100

    Added initial one-on-one call progress

commit db25cf213f5cb2706d9f36d4356b11b0e1d31cb3
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 10:14:11 2021 +1100

    Add files via upload

commit 03c5215c78e60890c17a9fabdf4b3e3d7af347b9
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 10:13:32 2021 +1100

    Add files via upload

commit a0db0022fc82f1b95261c72a84650f129522c67f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 10:11:33 2021 +1100

    Add files via upload

commit 5a5e0bde70a76ebe3b9437b9a861a89393daee90
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 10:11:14 2021 +1100

    Add files via upload

commit eac4c348fcc1a1f7506eefcb69f89482bae15732
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 10:10:38 2021 +1100

    Updated friendinfo dto

commit 85a5ed2f36255cefa454c64c9e4987eea8f734ce
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 29 10:10:04 2021 +1100

    Add files via upload

commit 0945347ddaafef614235488ba506e96cb0fa2c71
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 18:38:42 2021 +1100

    Added Local Preview->Call Demo Functionality

commit d6a11d6b4c021a512cc3c7c6a1434273652b464d
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 18:37:59 2021 +1100

    Added Local Preview->Call Demo Functionality

commit 0bd69420908c992be0acd0ca8dd576fe223d3f6a
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 18:37:15 2021 +1100

    Added Preview->Demo Functionality

commit 0bd40b58e1f682a973d20a9e689faaf4a1e638c3
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 17:48:11 2021 +1100

    Minor improvements and video test integration

commit e81f49f3c6b3819ec80ca4d0aaafc079129462c6
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 17:47:15 2021 +1100

    Added DeviceManager objects

commit 2b7cc9cf03403f16787b280cf3c6bcd228c6c8e1
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 17:46:42 2021 +1100

    Delete device-manager.service.ts

commit 4735218df7dd36a1b0ad41be43785518032bb36d
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 15:35:00 2021 +1100

    Added routing to local preview test

commit 24bcfe536ddba9aafba225636ddeb775cfb44b15
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 15:27:52 2021 +1100

    Fixed possibly undefined error

commit 5b24ddda65d1a0878b6695d1f56f377247fc1f9b
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 15:25:37 2021 +1100

    Added a temporary testing button for local preview

commit d65b43f0d7073180aacc4aa7332ef39f9d12590f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 15:24:50 2021 +1100

    Added local preview component
    
    - Async issue for getting device select lists. Temporarily worked around with manual timeout for 3s

commit a1804492d748348b5235e2a68c12d04831ca2f5d
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 15:23:33 2021 +1100

    Added Device Manager related service code

commit f625949f6d78eecb4b49b7befc0f22c69a68acd8
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 15:22:27 2021 +1100

    Added LocalPreview component

commit c18e843bf11cf0d2e70fb9d1079c7f964133fa8f
Merge: 279a066 9a46604
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 11:57:01 2021 +1100

    Merge pull request #26 from RMIT-COSC2650-SP3-2021-Team-3/ACS-code-restructure
    
    Acs code restructure (pt. 1)

commit 9a46604bbe37f1185d66a1867395f7f8e6a8a4ef
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 11:44:14 2021 +1100

    Disabled CallAgent in service for now

commit ecab9d5d37cc935baa528625f025257df5a726e3
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 11:43:21 2021 +1100

    Uses CallClient service now
    
    CallAgent has been left as is for now. I need to figure out how to load the event listeners separately

commit e2523ecc9712680c0dc83f8fefcbbce9cbe0dbea
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 10:54:17 2021 +1100

    Uses the ChatClient singleton service now

commit e40fceab90796b4b35f3096e130bae9bed5be42c
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 10:53:44 2021 +1100

    Uses the ChatClient singleton service now

commit acc10e1eefef648ec0f5cd2de23f923cb8df0a22
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 10:52:42 2021 +1100

    Removed Redundant Code

commit 078099fd142d560e27a1cc165989e6169f2dd800
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 10:52:09 2021 +1100

    Removed redundant code

commit c5ceb38056015875e4109476b78bac6934742718
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 10:50:13 2021 +1100

    Uses the ChatClient singleton service now

commit 1c4f1a5ae70f3fdafd9cfea0d8ea65abe7dfedca
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 10:49:02 2021 +1100

    Directory for acs-related singleton services
    
    - CallClient, CallAgent, ChatClient, and Acs token credential are initialised here
    - More acs-related services expected (such as devicemanager, selected speaker/cam/mic...)
    - This excludes the http-related service for the user's acs comm token on our database

commit 267704497ffcfb420b3d8cb73d1d8f23b812e18d
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 10:46:31 2021 +1100

    Removed harmful console logs

commit 1472b5e7893521d6da6499dfb60768e7ccaad785
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 10:45:48 2021 +1100

    Replacing these with singleton services

commit 30653acb52ff31aca32578e9400883fc2b51c0ab
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Wed Oct 27 10:45:11 2021 +1100

    Removed Unnecessary Reference to AcsTokenService

commit 29973afce535c39e69a87950a7c75d4b84b3fdf1
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Oct 26 13:30:18 2021 +1100

    Uses public static chatclient now

commit 67a99642a6482d30c961da5f90d27e7f60ec305a
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Oct 26 13:29:20 2021 +1100

    Uses public static chatclient now

commit ff07374dbb9ec39baaedc5b520c79a5860c9923a
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Oct 26 13:28:51 2021 +1100

    Add files via upload

commit bfec363025feefb36477486812d92989c1a89617
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Oct 26 13:28:17 2021 +1100

    Uses public static chatclient now

commit 5400c8b0e4bdc65b718c1919df98126358b4b0ea
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Oct 26 13:27:07 2021 +1100

    Added public static ChatClient

commit 1a6929b578df5cce3707986c2c9629d5355153da
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Oct 26 12:09:06 2021 +1100

    Fixed AcsControls name mismatch

commit a96b591d9241d5bccfed47747b227ef62fca4b14
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Oct 26 12:08:46 2021 +1100

    Fixed AcsControls name mismatch

commit 63dc2a22a6ec347ccdd06c5958721ed211ba6a62
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Oct 26 11:55:19 2021 +1100

    Now uses a static acs credential

commit 666fcbd9d41d087bf07899e9ca2b01b91da466b9
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Oct 26 11:54:25 2021 +1100

    Add files via upload

commit 7f25cc6f23a9a50e62db678e6b29f490a9a5626b
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Oct 26 11:52:10 2021 +1100

    Now uses a static acs credential

commit 336b0b5b001bbad86e3ee623dbc7bcb9ffcadefc
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Oct 26 11:36:41 2021 +1100

    Added acs object inits on register/login

commit da4bd474efd387367f535cd2047bf14284069396
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Tue Oct 26 11:36:07 2021 +1100

    Added acs object inits on login

commit 25fa3d870e709a8bd3af47dc98076e47b599f8d7
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Oct 25 14:02:27 2021 +1100

    ACS data init and response body update
    
    Untested

commit d209dce08cf98065eb6f0458b3c63447b9e838ae
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Oct 25 14:02:06 2021 +1100

    ACS data init and response body update
    
    Untested

commit b43106fb0b1f57e0d5ba7d718c2ba48d3e5951c2
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Oct 25 13:59:05 2021 +1100

    Uploaded to wrong folder

commit 35e895aaf0d74dc258d0f10c9824df6985a0ece3
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Oct 25 13:58:35 2021 +1100

    In-progress shared acs values impl
    
    Event binding and testing/configuration still needed

commit e927c26d0848ee1e615ab91c0ae287ee973d7871
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Oct 25 13:56:21 2021 +1100

    In-progress shared acs values impl
    
    Event binding and testing/configuration still needed

commit c44979b2ef03196b43b13aebe0d8d0c1d96da60a
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Oct 25 13:55:10 2021 +1100

    Reimplemented explicit refresh token function

commit 87e54fba3ef1c8c06760c8661f5a14565de0e993
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Mon Oct 25 13:54:09 2021 +1100

    Moved major acs code into global locations
    
    Currently broken

commit 279a0668cf5a6261749c35e62bcbf669cabbe923
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Oct 23 17:49:25 2021 +0100

    Add new unit testing run to our CI

commit 1d086dc2aa76f96b284ed8c405972c3dc4b5d0b9
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Oct 23 17:43:03 2021 +0100

    Add unit tests to `LoginComponent` to test form validity

commit 59e54792cfc16e2246ac065dc32cf1788f1a2d44
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Oct 23 17:42:41 2021 +0100

    Fix broken default unit tests (remove ones harder to fix for now)

commit f34cfc892e7c47cc7b06774a1307b2412c6b3918
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Oct 23 16:57:56 2021 +0100

    Consolidate all interfaces/types/models into a single types directory

commit ffcf31e3bec27e3a7611f094bbc5cffc5c9372b4
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Oct 23 16:53:05 2021 +0100

    Rename `Friendship` service to `SquabbleFriendshipService`

commit 6cf9b1ccbbe3a08edef1abc9e5af152199032079
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Oct 23 16:41:39 2021 +0100

    Consolidate all Squabble Team API services into a single service

commit 051dcbaa5404da348f4d7c89310572fefc1af7fa
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Oct 23 15:47:08 2021 +0100

    Better reload handling of the dashboard when a new team is added

commit 6026d58af5215904902fe4c9b8d5f1ad39c009a5
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Oct 23 15:29:28 2021 +0100

    Fix storing the user access token when signing in with SSO

commit 9f1d8b4008c90f61f1735e5356b206d7a82261c9
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Oct 23 11:06:22 2021 +0100

    Show loading spinner when processing user registration request

commit b08341e097f665127c8d2341d34a9c64997f3dac
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Oct 23 10:01:52 2021 +0100

    Dynamic registration form validators depending if SSO or not

commit 12f78fea6e2b92577b8178b6ec1cffe1c087361e
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Oct 23 09:57:56 2021 +0100

    Temp fix for SSO registration

commit 8c3fdf737ed63b0ca0ebe7c002ead135425aaafe
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Oct 23 09:28:07 2021 +0100

    Show a different registration page title if SSO

commit 9b33acd0bc65d8158bb523e0ea709774d1a5a7c0
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sat Oct 23 15:04:17 2021 +1100

    Fixed hardcoded user ID to use decoded token value

commit 34ed1498a037bf7452e37e9484d16fcd1eadb867
Merge: 11663b7 9c46cbe
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sat Oct 23 13:44:19 2021 +1100

    Merge pull request #25 from RMIT-COSC2650-SP3-2021-Team-3/register-profile-bugfix
    
    Added json handling for register post returns

commit 9c46cbedb34993ed844be3d3dd1a2b2b69084cdc
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sat Oct 23 13:43:10 2021 +1100

    Added json handling for register post returns

commit 11663b7bb98443a28edcbfde1e30f32f59cf6839
Merge: 9a99ac7 3033bf3
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sat Oct 23 11:39:59 2021 +1100

    Merge pull request #24 from RMIT-COSC2650-SP3-2021-Team-3/call-font-color-change
    
    Changed font to black

commit 3033bf3b61a7c595da28b9cb60b05480a8a8044f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Sat Oct 23 11:39:00 2021 +1100

    Changed font to black

commit 9a99ac7bfd5843976253987007bed0f4255af0be
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Sat Oct 23 10:17:20 2021 +1100

    Update dashboard.component.html

commit f9dbb6dafc2ca38e2687a4fdf236baf21fe2371a
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Sat Oct 23 10:14:09 2021 +1100

    Updated styling for chat and voice

commit 4af50540389fcb22fe01fcace4056d2d679265a2
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Oct 22 17:03:41 2021 +0100

    Improve add team channel UX

commit 42b1edc3e4f0c695c3c5a6a51f3916e37b3ed571
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Oct 22 16:48:26 2021 +0100

    Rename threads component to channels to match business language

commit 3dc4708302a046bcf06dfe9c6fa79817860b78b6
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Oct 22 16:44:45 2021 +0100

    Remove leftover and unused file

commit 260006cc1bef91bc718a5b37a1711470cec236c3
Merge: 6d978c1 0e5fe02
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Oct 22 17:05:13 2021 +0200

    Merge pull request #20 from RMIT-COSC2650-SP3-2021-Team-3/team-chat-integration
    
    Team chat integration

commit 6d978c1ffd8787ab98f0337b1dc55aec3cd1fcce
Merge: e6a379b 5c40491
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Fri Oct 22 21:55:22 2021 +1100

    Merge pull request #23 from RMIT-COSC2650-SP3-2021-Team-3/user-registration-form-validation
    
    Add form validation to user registration. No obvious issues with code. Merge accepted

commit 5c40491d0b2e52f4f25fb049b234f01ebe204159
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Oct 22 11:17:37 2021 +0100

    Add form validation to user registration

commit 0e5fe02b90c029fc004f9e3111ae11652dc2fe7c
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Fri Oct 22 18:05:40 2021 +1100

    Style changes

commit c92b5838f132c8f97e2e0fbc6f6b49ebaea8fd28
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Fri Oct 22 16:06:29 2021 +1100

    Update add-user-to-team-dialog.component.html

commit e6a379b46f427b206363770ce6a8926fc97a2dcf
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Fri Oct 22 15:48:46 2021 +1100

    Create Team Button

commit c18098ea7b6d2706a3fc28da17c748ce6828989b
Merge: 61c3626 3d5b5c5
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 13:55:57 2021 +1100

    Merge pull request #22 from RMIT-COSC2650-SP3-2021-Team-3/call-view-fix
    
    Update README.md

commit 3d5b5c58292267b9fa7396cce411c9768d32f3a3
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 13:55:43 2021 +1100

    Update README.md

commit 61c3626f8ec211b5cf3173118bcf0d3d9e851da3
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 13:54:20 2021 +1100

    Removed unnecessary characters from display

commit 998bdd67faed7b24142e536c670da967c00b5620
Merge: da99dfa 2e393b2
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 13:47:08 2021 +1100

    Merge pull request #21 from RMIT-COSC2650-SP3-2021-Team-3/friend-list-fix
    
    Changed environment to live url

commit 2e393b2b8ce20800fda38b9a6791029347210e89
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 13:46:19 2021 +1100

    Changed environment to live url

commit da99dfa47ba2a368c65c78feb4cbdfef28a0553f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 11:41:06 2021 +1100

    Add files via upload

commit 753477ed1185e947035ed4f0a1ed58f01f3c17dd
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 11:40:13 2021 +1100

    Add files via upload

commit 41e96cd15acf90a55dedfb9e323904a27dec2be1
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Fri Oct 22 11:39:42 2021 +1100

    Add files via upload

commit 50bfa91f62ca650b760bd18266c1fbb8a531d796
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 21 16:54:36 2021 +0100

    Add user to team chat channel

commit 57a841cc4623b599efe54144078af8e25e6e5ff7
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 21 15:37:56 2021 +0100

    Remove old group-chat component in favour of the server component

commit f241ecde10d6daf80b1b10d93802be695ec05047
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 21 14:51:23 2021 +0100

    Move chat creation from dashboard to inside a team

commit 24e8177139ebf19d4dd76fe8af8134b76400b0f5
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Thu Oct 21 22:01:45 2021 +1100

    Adjusted non-breaking style changes

commit d48e0ee50a1254d034acc7ba408cdafdc9bb11aa
Merge: 71ec662 87c289a
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Thu Oct 21 21:38:33 2021 +1100

    Merge pull request #16 from RMIT-COSC2650-SP3-2021-Team-3/security-questions
    
    Support setting and answering security questions when resetting password

commit 71ec662707be2c1de7791aa80aab54c38713301f
Merge: c20fb0a c57ede8
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Thu Oct 21 17:16:51 2021 +1100

    Merge pull request #19 from RMIT-COSC2650-SP3-2021-Team-3/1-on-1-front-end
    
    1 on 1 front end

commit c57ede8a4bf4322f45039bbc4647faef994b8fe5
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Thu Oct 21 17:16:20 2021 +1100

    Integrated voice into postloginlayout

commit c20fb0a482c062512418d53f71d7b8b9bed30bfe
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Thu Oct 21 15:18:32 2021 +1100

    Update group-chat.component.html

commit 79fd1c04577324f416fdb728599d0fba5a4255f3
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Oct 21 14:31:49 2021 +1100

    Add files via upload

commit c5c7d58f960c0c88da62e6c22f72abecdbf21c03
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Oct 21 14:23:46 2021 +1100

    Add files via upload

commit ee5a290eba1ada78b87d523ae62ef2363b108c3f
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Oct 21 14:23:09 2021 +1100

    Add files via upload

commit 42e52097d10b64cc4d3b92279ab2f7fcbc6edebe
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Oct 21 14:22:36 2021 +1100

    Add files via upload

commit b6031db7e5c79ca038e5aa63b4d73b38c5a97e5a
Author: Ryan Riddiford <54796727+RyanRiddiford@users.noreply.github.com>
Date:   Thu Oct 21 14:22:15 2021 +1100

    1-on-1 Call Functionality
    
    - Missing manual friend select
    - Buggy

commit a96b64e0050c14ce07c66350551abf7e145bff8f
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Wed Oct 20 22:50:28 2021 +1100

    Updated Dialogue Style

commit 93eb585d20511fe1d0a71e6b36a1b1f7a89bf811
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Wed Oct 20 22:14:59 2021 +1100

    Updated Team Tile Styling

commit f1fedc0936e79cdf6f8bd5f1c578b0d5a5d54b7b
Merge: 26ae7ce 98d2a6f
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Wed Oct 20 11:47:37 2021 +0200

    Merge pull request #18 from RMIT-COSC2650-SP3-2021-Team-3/add-users-to-team
    
    Add users to team

commit 98d2a6fd8965b3fcdfae9cf74d5334573a45d6f8
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Tue Oct 19 14:11:58 2021 +0100

    Move Team Tile component into the components folder

commit 522c7b4a95d8846a6ea1fa4998f49fabaa84855a
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Tue Oct 19 13:36:28 2021 +0100

    Dynamically navigate to route for the specific Server ID

commit a5842065171908953f77e631a270b2b4e2a95e1e
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Tue Oct 19 17:46:44 2021 +1100

    Added refresh of dashboard component once new team has been added

commit 3df638156e5a8ef7d5f40ad8f3b83500db1f01bf
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Tue Oct 19 14:38:13 2021 +1100

    Added find by username service. Is called before passing id to add user service.

commit e880f6d8fa79f94396ccf44f5eaa6a282fb42697
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Tue Oct 19 13:11:47 2021 +1100

    Added changes to adding users to server by user id

commit f7233cde2c48c17b86d47531af7ea0b2af0f647a
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Mon Oct 18 08:27:10 2021 +1100

    Added service to add users to a team

commit 3fda239938bec4cc60e472aeb00521e1c6a45064
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sun Oct 17 14:23:03 2021 +1100

    Added basic components for adding users to team dialogue box

commit f20bea49bdca5b3358235d1aab174e4b8dcb1618
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sun Oct 17 13:19:01 2021 +1100

    Added service to call all server ids based on user

commit 94db40d654b78a2d7f3e79246b00bc3e03ae1cad
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sun Oct 17 13:02:14 2021 +1100

    Added for loop to loop through all servers for team tiles

commit a4f25bd449ba1d53da55b370aa9198c499043b5e
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sun Oct 17 12:44:57 2021 +1100

    Changes to API resulting in different parameters passed to service and token

commit 45ebb3c44ab2d0fbfc0931cc2831d68f34c7ef0f
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sun Oct 17 12:29:42 2021 +1100

    Added basic tile display based on server number passed in HTML

commit 071459c7dca8371825b793851bcbf0db094818ea
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sat Oct 16 10:43:02 2021 +1100

    Created team tile component to hold team name, buttons, etc

commit 0b465a098325511f1a5df34cca8492efe739e669
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Fri Oct 15 23:45:53 2021 +1100

    Syntax error fixed

commit bb60071787455bda33d08775807efcf927fa9ed8
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Fri Oct 15 23:36:51 2021 +1100

    Start of adding user as a member to the newly created team

commit 85cf83659b8b5fbdf4b5115901df0c04ce5842d0
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Fri Oct 15 19:30:57 2021 +1100

    User is now assigned ownership when creating the team

commit 073293794c9df89595b5c4c5c4063cc40872b0cc
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Fri Oct 15 15:27:07 2021 +1100

    Added ability to click button to add team, pop up, and send team name to database for creation

commit 9a3ab0d63517c12f9f1e5469bdb3feec85b5c33f
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Fri Oct 15 12:31:49 2021 +1100

    Added temporary button

commit 26ae7ce868a045fe6855476b16422b9a5196f12a
Merge: f79f208 4467d09
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Wed Oct 20 11:22:20 2021 +0200

    Merge pull request #17 from RMIT-COSC2650-SP3-2021-Team-3/useAcsTokenFromDatabase
    
    Use acs token from database

commit 4467d09f947e7181e3fbbb825cb5ff7a764f3849
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Wed Oct 20 13:42:10 2021 +1100

    add ability to get current user data from a service. Fix with listing of historic message layout

commit 6dc4bb0e41250eb6bae3247a9e892f090f58fdf0
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Wed Oct 20 09:43:19 2021 +1100

    use token from database instead of session storage

commit 2f4ed7500d4fb48382af4d9219ce0df847b8917a
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Tue Oct 19 16:08:58 2021 +1100

    change User.ts class name back to User

commit 9cdb8f0d8699d3475334a3c77bc616bf0dfb28c8
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Tue Oct 19 16:06:18 2021 +1100

    adjustment made to use ACS token retrieved from the database instead of creating a new one in the dashboard view

commit f79f2088457e0781d3d1506451da048f3bdced1b
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Tue Oct 19 13:44:00 2021 +1100

    remove unused code

commit 87c289ac1f1aa70606cbe73094399077565ca895
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Oct 18 15:33:32 2021 +0100

    Support setting and answering security questions when resetting password

commit 35698c2938fdaf9329c2eb48494f3b320a5bf585
Merge: 0f84851 f33ee0f
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Mon Oct 18 07:21:49 2021 +1100

    Merge pull request #15 from RMIT-COSC2650-SP3-2021-Team-3/front-end-chat-component
    
    Created thread module and component.

commit f33ee0f4194c0a1e61a1cc4caac09b45c3033b8c
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Mon Oct 18 07:21:23 2021 +1100

    Created thread module and component.

commit 0f84851e4d039283fc41be1c4bb976d9b4d59106
Merge: 306c6b4 d07f31e
Author: Gerard Anderson <61717348+s3318814@users.noreply.github.com>
Date:   Fri Oct 15 12:50:35 2021 +1100

    Merge pull request #14 from RMIT-COSC2650-SP3-2021-Team-3/pressEnterToSubmitMessage
    
    Code does not appear to cause any issues

commit d07f31ede70db713622243edc03a9e97fbfb56a2
Merge: 6ca6ad5 306c6b4
Author: Duc Tran <55226475+s3500659@users.noreply.github.com>
Date:   Fri Oct 15 11:11:36 2021 +1100

    Merge branch 'master' into pressEnterToSubmitMessage

commit 6ca6ad5959585583b0cbb379f16644e9fbaaa5ab
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Fri Oct 15 09:29:48 2021 +1100

    add submit message on enter key function

commit 306c6b483ded4eda34d1cd4e363cb9f6e5c7fd4a
Merge: d74ae40 5e49ad6
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 14 16:20:35 2021 +0200

    Merge pull request #13 from RMIT-COSC2650-SP3-2021-Team-3/update-profile
    
    Move user profile to its own view with ability to update info

commit 5e49ad63cd6029548a4800210127c6016befb204
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Oct 4 18:03:42 2021 +0200

    Move user profile to its own view with ability to update info

commit d74ae40a874fc4ff916039fad0b37a8cca3a490b
Merge: 7b59f50 e2ded98
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 14 15:54:48 2021 +0200

    Merge pull request #5 from RMIT-COSC2650-SP3-2021-Team-3/reset-password
    
    Add support for reset password

commit e2ded9821b2c276d5d6388e7666e312ac9ff85da
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 7 07:40:02 2021 +0100

    Fix Material Design overriding Poppins font and import font locally

commit 47a1f45549a2b0df1f902544f5cd3624b797627d
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Tue Oct 5 14:50:56 2021 +0200

    Add styles to register view

commit 3721ca2b43338d073e69618e4437a459080a556b
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Tue Oct 5 14:47:33 2021 +0200

    Add styles to forgot password view

commit ddda8427546a5190fefbadd079a6ab66d4ba0870
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Tue Oct 5 14:31:17 2021 +0200

    Fix broken link since rebase on master branch

commit f5d499faa68e29125a7b5d19aedc58a68d7e58af
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sat Oct 2 17:16:07 2021 +0200

    Display API response errors to the user

commit 612e77b0cb149138013cd6168241793a6439c2a6
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Wed Sep 29 18:00:58 2021 +0200

    Add client side form validation for password reset

commit 5c9b05fa831192a8c96922371137468bea42e42c
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Wed Sep 29 16:40:30 2021 +0200

    Add support for password resets (no email reset yet)

commit 7b59f50ee3c0d5b9442e652f9406017d72b7ab89
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Thu Oct 14 10:30:54 2021 +0100

    Update API URL to new URL

commit 2cad523fd94a5d328213a75dea4dd4748c912b84
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Wed Oct 13 16:57:55 2021 +1100

    add ability to show previous messages in a chat thread

commit e52499caad6e4800901c02a128d23d12b3f3291a
Merge: aedb598 8f0a6ed
Author: Duc Tran <55226475+s3500659@users.noreply.github.com>
Date:   Mon Oct 11 08:54:44 2021 +1100

    Merge pull request #12 from RMIT-COSC2650-SP3-2021-Team-3/azure-text-chat-integration-with-view
    
    Azure text chat integration with view

commit 8f0a6ed231bd231b5e5e9e94a380420dcf32c9a6
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Sat Oct 9 07:56:20 2021 +1100

    refactor to use environment variables and code clean up

commit 93f7370ef63533a93b1f26970e4debf5f702f18a
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Fri Oct 8 17:24:26 2021 +1100

    minor code refactor

commit 24f5c3c4ad14950e17d4297ac522b78437bc9596
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Fri Oct 8 17:00:49 2021 +1100

    add user model class

commit 2d9413877b138cc14041faf8111f1a5d49667817
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Thu Oct 7 22:09:13 2021 +1100

    updated get account data service and removed id param

commit 89590b33b7a5d901b10a76709fa139d151827f95
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Thu Oct 7 11:05:54 2021 +1100

    save

commit 5cea690a33b59e8f1240800c2ca6a985ce37af90
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Thu Oct 7 08:42:36 2021 +1100

    save

commit 05bf387e018e0d3e698052adb121043020aace76
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Thu Oct 7 07:56:22 2021 +1100

    save

commit ae8044d16560ba43c3aaa87c90a2af523932e2da
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Thu Oct 7 07:55:19 2021 +1100

    integrate group chat function with view

commit 60bbb907f538924966dcf0a90e62145442efc40c
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Wed Oct 6 16:32:12 2021 +1100

    hook send and receive message function to view

commit 0352735ab9d4f4295785513a6ebdb03a8ebf4a26
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Wed Oct 6 14:07:11 2021 +1100

    hook up thread creation to dashboard view

commit a02488596208f6d78b5577da2a9c07e791670dc8
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Tue Oct 5 16:33:18 2021 +1100

    add dialog for groupName input

commit 4c302ae4c88c12b20d673a02df18a0968fa25bb7
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Tue Oct 5 13:51:23 2021 +1100

    add token service

commit aedb5981fefbd19709888605b3dd2abd42e1b189
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Oct 8 17:20:59 2021 +0100

    Bump max style size error limit

commit 38ee3cedd584925a8f9e73c2968e1cfcbaf995fe
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Wed Oct 6 18:43:53 2021 +1100

    Removed excess styling

commit 496004e9e8f6a2770e2eddbe6f0a0e213dc51e8f
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Wed Oct 6 18:40:50 2021 +1100

    Fixed inner chat styling

commit 5c649397be9a51714d7b977de482f19096ca8ffe
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Wed Oct 6 18:28:55 2021 +1100

    Fixed chat bubble styling.

commit 2e95d7f88a856fc4b1279041e8980457194d5a9a
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Tue Oct 5 14:33:54 2021 +0200

    Fix broken auth links

commit b0e737826601222ecacd77ce9dbf48695601fa07
Merge: eec122d 39fa0fb
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Tue Oct 5 08:38:39 2021 +1100

    Merge pull request #6 from RMIT-COSC2650-SP3-2021-Team-3/interface
    
    Interface

commit 39fa0fb370e902b21633f51ba3f6c99df25ce807
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Tue Oct 5 08:37:47 2021 +1100

    Removed unused styling from testing.
    
    - Removed excess code on inner component and group chat component SCSS.
    - Need to create SCSS file that is referenced by both.
    - Need to remove individual reference to bootstrap styling.

commit 72f42b085acc919ce17eb1070d0961efcb90310e
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Oct 4 17:36:02 2021 +0200

    Only show main layout on post login views and pre-login has own layout

commit 579c674d023d8da6da9e52c249e4f63c9902eca1
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Oct 4 16:55:13 2021 +0200

    Fix `@ng-bootstrap/ng-bootstrap` dep version in `package.json`

commit 4627b4e3fcf0090e139b502b965e5a3a448f1d3e
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Mon Oct 4 16:56:05 2021 +1100

    Removed cards components.

commit c4ccf3bd2f1471a342851efae66fcdc19353624f
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Mon Oct 4 16:42:35 2021 +1100

    Integrated Chat Component & Styling
    
    - Contact menu
    - Chat window
    - Updated sidenav
    - Updated header
    - Created profile icons
    - Created message models (To Be Replaced)

commit 209dbf24dbd214bb8b607b8d312dd8100ec01737
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Thu Sep 30 17:49:11 2021 +1000

    Updated nav

commit cc65913c2e7fe917404c8f347d0403be2822d1a3
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Thu Sep 30 17:29:53 2021 +1000

    Updated dashboard styling

commit 549926e6baad81529005327a84569696f2b9450f
Author: Quinn Goh <51525668+s3724287@users.noreply.github.com>
Date:   Wed Sep 29 23:54:51 2021 +1000

    Created dashboard & side rail

commit eec122d4df5e90f7bb6c688a860572cc98d3585c
Merge: 53efa60 8e4e329
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Oct 4 18:03:17 2021 +0200

    Merge pull request #7 from RMIT-COSC2650-SP3-2021-Team-3/show-log-in-success
    
    Show account data on login success

commit 8e4e329af99921f3fc7428b79d3e42bf437aec8d
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Sun Oct 3 21:22:21 2021 +0200

    Update fetching account details to work with new account endpoint

commit bcafdb15ea169eb33f25441810617a6dda20feb4
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sat Oct 2 17:09:05 2021 +1000

    Refactored code out to service. Changed init to constructor

commit b9a37bc9007901a8537f2fe268fc21de4aa9682e
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sat Oct 2 17:08:18 2021 +1000

    Removed console logging

commit 24e1a878df567c9bc66dbab8993a900cfd692095
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sat Oct 2 17:07:24 2021 +1000

    Refactored api calls to service

commit 03c1876b154288275e995eb1d834fc97c58bc397
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sat Oct 2 16:14:50 2021 +1000

    Call API and assign returned data to variables

commit e2365c2da5b597c9cae1957a3040b72bd3976467
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sat Oct 2 16:14:31 2021 +1000

    Added html to display account data

commit 2dc4cb47367e3f831bdd438ec69a852d4dce8459
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sat Oct 2 14:47:19 2021 +1000

    Updated login due to change in data structure returned by API

commit 53efa60067e1368a42d809a66df4b1a1c41967d3
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Sep 27 07:42:20 2021 +0100

    Add dynamic site URL depending on prod vs dev

commit 609ad4efc2f79381f27c88638ca8aebf9bcc511d
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Sep 27 07:37:42 2021 +0100

    Add navigation fallback route for Angular SPA

commit 30340e96c599ecdf6d23ca5d95d0f6f74d3cacfe
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Sep 27 07:23:11 2021 +0100

    Update login form password field type to hide input

commit 3e92218d51c302cf5c1a38ea73bc2501169791e9
Merge: e73dec8 d8417ec
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Sep 27 06:39:05 2021 +0100

    Merge pull request #3 from RMIT-COSC2650-SP3-2021-Team-3/microsoft-sso
    
    Add support for Microsoft SSO

commit d8417ec21ed1e5bf6daa512078d893bc1d0b7126
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Sep 27 06:05:25 2021 +0100

    Add support for Microsoft SSO

commit 807733b4942007a78d0a4f2c5fc16fb29686a77d
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Fri Sep 24 21:01:18 2021 +0100

    Use local Bootstrap styles instead of pulling from Internet

commit e73dec86eaee1b44ebe143ea38f603f0d12f285b
Merge: 271d216 56501a1
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Sep 27 06:06:40 2021 +0100

    Merge pull request #2 from RMIT-COSC2650-SP3-2021-Team-3/sigin-in
    
    Sign in

commit 56501a1e861fa75977c2d4d3c372439582392cab
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Mon Sep 27 14:30:31 2021 +1000

    Styled sign in as per prototype

commit b6cbe706e7a1b10e601ac92fbb7fc6737ac27c84
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Mon Sep 27 13:42:23 2021 +1000

    Added empty dashboard page for redirect

commit 2890ffd5db431cce09ce0a4e29f03f1820a851c6
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sat Sep 25 13:39:14 2021 +1000

    Store token, display error incorrect login, route

commit d396ddcc11f3a97121fd411871efd4817fc56392
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sat Sep 25 13:38:10 2021 +1000

    Additional styling to paddings and position

commit 8111b037532ed8698bb255c7490848961bfa11d4
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sat Sep 25 13:37:37 2021 +1000

    Changed fields to match backend

commit f3997d74b2283f56f0111b6364c1e176226b7fa1
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Sat Sep 25 13:37:10 2021 +1000

    Changed type to User class

commit 1cdbb11fb4f34fa311bb3302ff9952626a6dbb22
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Thu Sep 23 17:57:57 2021 +1000

    Changes to field names to match API

commit e2af423067a5ec25d2786c3f7c64aa46fc0f375b
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Thu Sep 23 17:35:17 2021 +1000

    Changed to signInGroup.value pass in post request

commit 71d6739b24690eb34eaa58c1a78dc153bfb910aa
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Thu Sep 23 17:23:02 2021 +1000

    Started Post request implementation

commit 6b4d0149135ceab9b3d36f6d2058f88e9a381f2c
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Thu Sep 23 14:39:21 2021 +1000

    Implemented form and start of httpclient

commit aa1e43486bd0ef6eed31127f0f483f5542f6261a
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Thu Sep 23 14:39:07 2021 +1000

    Implemented blocks in background

commit b0afb9d2cb7aa99d9b35aa0c68617c3ab4d62b8f
Author: Gerard Anderson <61717348+gerardmanderson@users.noreply.github.com>
Date:   Thu Sep 23 13:17:58 2021 +1000

    Implemented basic fields, buttons, text

commit 271d2167819d9448cf3832338aa85f6039d62337
Merge: cc27a38 675371e
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Sep 20 22:20:20 2021 +0100

    Merge pull request #1 from RMIT-COSC2650-SP3-2021-Team-3/test-pr-workflow
    
    Remove unused workflow field (and test PR workflow at same time)

commit 675371e3c54c6d4f93231042eef0bfae21b3400f
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Sep 20 22:13:19 2021 +0100

    Remove unused workflow field (and test PR workflow at same time)

commit cc27a3856f3b2e5598cb9db147a616e3a28a3f2b
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Sep 20 22:07:54 2021 +0100

    Add support for SCSS (CSS still works fine if you don't know SCSS)

commit 9871662f9321e1f49f9504b18c5de6b79932b56c
Author: Mitchell Cash <mitchell@mitchellcash.com>
Date:   Mon Sep 20 22:06:33 2021 +0100

    Fix build output path in CI/CD workflow

commit 1d57fde3d9d46bd97c2fd60ad96e0a6c37393df5
Author: Mitchell Cash <me@mitchellcash.com>
Date:   Mon Sep 20 21:55:59 2021 +0100

    ci: add Azure Static Web Apps workflow file
    on-behalf-of: @Azure opensource@microsoft.com

commit 1ea76b8e8946975470fb137143000183e401c2d7
Author: Duc Tran <vinhdt90@outlook.com>
Date:   Tue Sep 14 12:16:58 2021 +1000

    initial commit
