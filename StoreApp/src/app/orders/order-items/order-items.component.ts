import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { Item } from 'src/app/shared/item.model';
import { ItemService } from 'src/app/shared/item.service';
import { OrderItem } from 'src/app/shared/order-item.model';
import { Order } from 'src/app/shared/order.model';

@Component({
  selector: 'app-order-items',
  templateUrl: './order-items.component.html',
  styles: [
  ]
})
export class OrderItemsComponent implements OnInit {
  formData: OrderItem;
  itemList: Item[];

  constructor(
    @Inject(MAT_DIALOG_DATA) public data,
    public dialogRef: MatDialogRef<OrderItemsComponent>,
    private itemService: ItemService) { }


  ngOnInit() {
    this.itemService.getItemList().then(res => this.itemList = res as Item[]);



    this.formData = {
      OrderId: null,
      OrderID: this.data.OrderID,
      Id: 0,
      ItemName: '',
      Price: 0,
      Quantity: 0,
      Total: 0
    }
  }

}
