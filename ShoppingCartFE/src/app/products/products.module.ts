import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductDetailComponent } from './product-detail/product-detail.component';
import { ProductListComponent } from './product-list/product-list.component';
import { CoreModule } from '../core/core.module';
import { ProductsRoutingModule } from './products-routing.module';

@NgModule({
  declarations: [
    ProductListComponent,
    ProductDetailComponent
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  imports: [
    CommonModule,
    ProductsRoutingModule,
    CoreModule
  ]
})
export class ProductsModule { }
