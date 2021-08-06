import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { OrderComponent } from './orders/order/order.component';

//Rota de acesso a orders
const routes: Routes = [
  { path: '', redirectTo: 'order', pathMatch: 'full' },
  { path: 'orders', component: OrderComponent },
  {
    path: 'order', children: [
      { path: '', component: OrderComponent },
      { path: 'edit/:id', component: OrderComponent }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
