import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IconCardComponent } from './icon-card/icon-card.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [IconCardComponent],
  imports: [
    CommonModule,
    RouterModule
  ]
})
export class IconCardModule { }
