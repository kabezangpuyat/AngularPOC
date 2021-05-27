import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppuserComponent } from './appuser.component';

describe('AppuserComponent', () => {
  let component: AppuserComponent;
  let fixture: ComponentFixture<AppuserComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AppuserComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppuserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
