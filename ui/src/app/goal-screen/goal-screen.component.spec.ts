import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoalScreenComponent } from './goal-screen.component';

describe('GoalScreenComponent', () => {
  let component: GoalScreenComponent;
  let fixture: ComponentFixture<GoalScreenComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [GoalScreenComponent]
    });
    fixture = TestBed.createComponent(GoalScreenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
