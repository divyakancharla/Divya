import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SwitchIntroComponent } from './switch-intro.component';

describe('SwitchIntroComponent', () => {
  let component: SwitchIntroComponent;
  let fixture: ComponentFixture<SwitchIntroComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SwitchIntroComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SwitchIntroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
