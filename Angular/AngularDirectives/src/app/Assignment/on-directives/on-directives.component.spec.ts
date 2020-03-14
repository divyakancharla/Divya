import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OnDirectivesComponent } from './on-directives.component';

describe('OnDirectivesComponent', () => {
  let component: OnDirectivesComponent;
  let fixture: ComponentFixture<OnDirectivesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OnDirectivesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OnDirectivesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
