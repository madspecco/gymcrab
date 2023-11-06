import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BiometricsScreenComponent } from './biometrics-screen.component';

describe('BiometricsScreenComponent', () => {
  let component: BiometricsScreenComponent;
  let fixture: ComponentFixture<BiometricsScreenComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [BiometricsScreenComponent]
    });
    fixture = TestBed.createComponent(BiometricsScreenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
