import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WorkoutsScreenComponent } from './workouts-screen.component';

describe('WorkoutsScreenComponent', () => {
  let component: WorkoutsScreenComponent;
  let fixture: ComponentFixture<WorkoutsScreenComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [WorkoutsScreenComponent]
    });
    fixture = TestBed.createComponent(WorkoutsScreenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
