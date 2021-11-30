import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';
import { FormControl, FormGroup, FormArray } from '@angular/forms';
import {MAT_DIALOG_DATA} from '@angular/material/dialog';
import { GetUserByUsernameService } from 'src/app/services/get-user-by-username.service';
import { SquabbleFriendshipService } from 'src/app/services/squabble-friendship.service';
import { JwtHelperService } from '@auth0/angular-jwt';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-add-friend-dialog',
  templateUrl: './add-friend-dialog.component.html',
  styleUrls: ['./add-friend-dialog.component.scss']
})
export class AddFriendDialogComponent implements OnInit {

  findUserByUserNameForm = new FormGroup({
    username: new FormControl('')
  })

  constructor(
    private dialogRef: MatDialogRef<AddFriendDialogComponent>,
    private getUserByUsernameService: GetUserByUsernameService,
    private squabbleFriendshipService: SquabbleFriendshipService,
    private notification: MatSnackBar
  ) { }

  ngOnInit(): void {
  }

  close() {
    this.dialogRef.close()
  }

  addFriend() {
    if(this.findUserByUserNameForm.value.username == ''){
      this.openNotification("Field cannot be blank", 'error-notification')
    }
    
    this.getUserByUsernameService.getUserData(this.findUserByUserNameForm).subscribe((user) => {
      if (user) {
        this.squabbleFriendshipService.sendFriendRequest(user.accountId).subscribe(() => {
          this.squabbleFriendshipService.reloadFriendList();
          this.dialogRef.close();
        });
      } else {
        // Notification displayed where user is not found
        this.openNotification("User cannot be found. Check the username and try again.", 'error-notification')
      }
    })
  }

    // Notification 
    openNotification(message: string, type: string) {
      this.notification.open(message, '', 
        {
          duration: 4000,
          verticalPosition: 'top',
          panelClass: [type]
        });
    }

}
