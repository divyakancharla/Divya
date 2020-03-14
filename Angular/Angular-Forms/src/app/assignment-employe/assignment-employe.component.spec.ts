import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AssignmentEmployeComponent } from './assignment-employe.component';

describe('AssignmentEmployeComponent', () => {
  let component: AssignmentEmployeComponent;
  let fixture: ComponentFixture<AssignmentEmployeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AssignmentEmployeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AssignmentEmployeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
