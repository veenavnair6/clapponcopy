import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RepairComponent } from './repair/repair.component';
import { RepairStartComponent } from './repair-start/repair-start.component';
import { RepairRoutingModule } from './repair-routing.module';



@NgModule({
  declarations: [RepairComponent, RepairStartComponent],
  imports: [
    CommonModule,
    RepairRoutingModule
  ]
})
export class RepairModule { }
