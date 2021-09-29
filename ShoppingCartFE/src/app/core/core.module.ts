import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ElipsisPipe } from './pipe/elipsis.pipe';
import { ProductComponent } from './product/product.component';
import { BackgroundDirective } from './directive/background.directive';
import { RouterModule } from '@angular/router';
import { ErrorPageComponent } from './error-page/error-page.component';
import { CartComponent } from './cart/cart.component';
import { OrderComponent } from './order/order.component';



@NgModule({
  declarations: [
    ElipsisPipe,
    ProductComponent,
    BackgroundDirective,
    ErrorPageComponent,
    CartComponent,
    OrderComponent
  ],
  imports: [
    CommonModule,
    RouterModule
  ],
  exports : [
    ElipsisPipe,
    ProductComponent,
    BackgroundDirective,
    ErrorPageComponent
  ]
})
export class CoreModule { }
