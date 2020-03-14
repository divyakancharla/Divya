import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OnLineCustomerComponent } from './on-line-customer.component';

describe('OnLineCustomerComponent', () => {
  let component: OnLineCustomerComponent;
  let fixture: ComponentFixture<OnLineCustomerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OnLineCustomerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OnLineCustomerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
