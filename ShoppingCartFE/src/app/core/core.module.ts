import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ElipsisPipe } from './pipe/elipsis.pipe';
import { BackgroundDirective } from './directive/background.directive';



@NgModule({
  declarations: [
    ElipsisPipe,
    BackgroundDirective
  ],
  imports: [
    CommonModule
  ],
  export: [
    ElipsisPipe
  ]
})
export class CoreModule { }
