import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ElipsisPipe } from './pipe/elipsis.pipe';
import { ProductComponent } from './product/product.component';
import { BackgroundDirective } from './directive/background.directive';



@NgModule({
  declarations: [
    ElipsisPipe,
    ProductComponent,
    BackgroundDirective
  ],
  imports: [
    CommonModule
  ],
  exports : [
    ElipsisPipe,
    ProductComponent,
    BackgroundDirective
  ]
})
export class CoreModule { }
