import { Injectable } from '@angular/core';
import { OrderItem } from './order-item.model';
import { Order } from './order.model';

@Injectable({
  providedIn: 'root'
})
export class OrderService {
  formData: Order = new Order();
  orderItems: OrderItem[]; //Lista de itens do pedido


  constructor() { }
}
