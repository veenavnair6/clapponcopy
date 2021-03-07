import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RepairStartComponent } from './repair-start.component';

describe('RepairStartComponent', () => {
  let component: RepairStartComponent;
  let fixture: ComponentFixture<RepairStartComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RepairStartComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RepairStartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
