import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
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

  constructor(
    @Inject(MAT_DIALOG_DATA) public data,
    public dialogRef: MatDialogRef<OrderItemsComponent>) { }


  ngOnInit() {
    this.formData = {
      OrderItemID: null,
      OrderID: this.data.OrderID,
      ItemID: 0,
      ItemName: '',
      Price: 0,
      Quantity: 0,
      Total: 0
    }
  }

}
