import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DeviceListComponent } from './device-list/device-list.component';
import { DeviceComponent } from './device/device.component';



@NgModule({
  declarations: [DeviceListComponent, DeviceComponent],
  imports: [
    CommonModule
  ]
})
export class SharedModule { }
