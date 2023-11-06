import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ActivityScreenComponent } from './activity-screen.component';

describe('ActivityScreenComponent', () => {
  let component: ActivityScreenComponent;
  let fixture: ComponentFixture<ActivityScreenComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ActivityScreenComponent]
    });
    fixture = TestBed.createComponent(ActivityScreenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
