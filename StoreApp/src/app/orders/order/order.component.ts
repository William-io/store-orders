import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { OrderService } from 'src/app/shared/order.service';

import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { OrderItemsComponent } from '../order-items/order-items.component';



@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styles: [
  ]
})
export class OrderComponent implements OnInit {

  constructor(public service: OrderService,
    private dialog: MatDialog) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form = null)
      form.resetForm();
    this.service.formData = {
      OrderID: null,
      OrderNo: Math.floor(100000 + Math.random() * 900000).toString(),
      CustomerID: 0,
      PaymentMethod: '',
      GrandTotal: 0,
    };
    this.service.orderItems = [];
  }


  AddOrEditOrderItem(orderItemIndex, OrderID) {
    const dialogConfig = new MatDialogConfig();
    dialogConfig.autoFocus = true;
    dialogConfig.disableClose = true;
    dialogConfig.width = "50%";
    dialogConfig.data = { orderItemIndex, OrderID };
    this.dialog.open(OrderItemsComponent, dialogConfig);
  }

}
