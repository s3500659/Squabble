import { CdkDragDrop, moveItemInArray, transferArrayItem } from '@angular/cdk/drag-drop';
import { Component, OnInit } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { JwtHelperService } from '@auth0/angular-jwt';
import { AddKanbanItemDialogComponent } from '../../components/add-kanban-item-dialog/add-kanban-item-dialog.component';
import { DeleteKanbanConfirmationDialogComponent } from '../../components/delete-kanban-confirmation-dialog/delete-kanban-confirmation-dialog.component';
import { EditKanbanItemDialogComponent } from '../../components/edit-kanban-item-dialog/edit-kanban-item-dialog.component';
import { SquabbleKanbanService } from '../../services/squabble-kanban.service';

interface item {
  kanbanItemID: number,
  listName: string,
  itemName: string,
  position: number
}

@Component({
  selector: 'app-kanban',
  templateUrl: './kanban.component.html',
  styleUrls: ['./kanban.component.scss']
})

export class KanbanComponent implements OnInit {

  // Set up array objects for each list
  toDo: item[] = []
  inProgress: item[] = []
  done: item[] = []

  constructor(
    private dialog: MatDialog,
    private kanbanService: SquabbleKanbanService
  ) { }

  ngOnInit(): void {
    this.getItems()
  }

  // Handles drag and drop functionality
  drop(event: CdkDragDrop<item[]>) {
    if (event.previousContainer === event.container) {
      moveItemInArray(event.container.data, event.previousIndex, event.currentIndex);
    } else {
      transferArrayItem(event.previousContainer.data,
        event.container.data,
        event.previousIndex,
        event.currentIndex);
    }

    this.updateItemAfterDrag(
      event.container.data,
      event.previousContainer.data,
      event.currentIndex,
      event.container.id,
      event.previousContainer.id
    )
  }

  // Add a new item via dialogue box
  addItem(list: item[], listName: string) {
    const dialogConfig = new MatDialogConfig();
    dialogConfig.autoFocus = true;

    this.dialog.open(
      AddKanbanItemDialogComponent,
      {data: {list, listName}, panelClass:'custom-dialog-container'}
    ).afterClosed().subscribe(() => {
      this.getItems();
    })
  }

  // Edit the name of an item via dialogue box
  editItemName(item: item, list: item[]) {
    const dialogConfig = new MatDialogConfig();
    dialogConfig.autoFocus = true;

    this.dialog.open(
      EditKanbanItemDialogComponent,
      {data: {item, list}, panelClass:'custom-dialog-container'}
    )
  }

  // Delete an item from the list and database
  deleteItem(item: item, list: item[]) {
    const dialogConfig = new MatDialogConfig();
    dialogConfig.autoFocus = true;

    this.dialog.open(
      DeleteKanbanConfirmationDialogComponent,
      {data: {item, list}, panelClass:'custom-dialog-container'}
    )

  }

  // Return all items for the user
  getItems() {
    this.toDo = []
    this.inProgress = []
    this.done = []

    this.kanbanService.getItems().subscribe(data => {
      data.forEach((element: any) => {
        if (element.listName == "toDo") {
          this.toDo.push(element)
        }

        if (element.listName == "inProgress") {
          this.inProgress.push(element)
        }

        if (element.listName == "done") {
          this.done.push(element)
        }
      });
    })
  }

  // Updates the item after it has moved into another list
  updateItemAfterDrag(list: item[], previousList: item[], newPosition: number, newList: string, oldList: string) {

    const newListIndex: number = parseInt(newList.charAt(newList.length - 1)) % 3
    newList = this.getListName(newListIndex);

    const oldListIndex: number = parseInt(oldList.charAt(oldList.length - 1)) % 3
    oldList = this.getListName(oldListIndex);

    // Assign new list positions
    for (let i = 0; i < list.length; i++) {
      let item: item = {
        kanbanItemID: list[i].kanbanItemID,
        itemName: list[i].itemName,
        listName: newList,
        position: i
      }

      this.kanbanService.updateItem(item).subscribe()
    }

    // Assign previous list positions to fill gap
    for (let i = 0; i < previousList.length; i++) {
      let item: item = {
        kanbanItemID: previousList[i].kanbanItemID,
        itemName: previousList[i].itemName,
        listName: oldList,
        position: i
      }

      this.kanbanService.updateItem(item).subscribe()
    }
  }

  // Returns name of list based on the angular list number
  getListName(index: number) {
    if (`cdk-drop-list-${index}` === 'cdk-drop-list-0') {
      return 'toDo';
    }

    if (`cdk-drop-list-${index}` === 'cdk-drop-list-1') {
      return 'inProgress';
    }

    if (`cdk-drop-list-${index}` === 'cdk-drop-list-2') {
      return 'done';
    }

    return 'fail';
  }
}
