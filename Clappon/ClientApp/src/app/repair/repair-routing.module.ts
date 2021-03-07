import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RepairStartComponent } from './repair-start/repair-start.component';
import { RepairComponent } from './repair/repair.component';

const routes: Routes = [
  {
    path: '',
    component: RepairComponent,
    children: [
      {
        path: '', pathMatch: 'full', redirectTo: 'start'
      },
      {
        path: 'start', component: RepairStartComponent
      }
    ]
  }
];

@NgModule({
  imports: [
    RouterModule.forChild(routes)
  ],
  exports:[RouterModule]
})
export class RepairRoutingModule { }