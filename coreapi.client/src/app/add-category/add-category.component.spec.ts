import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddCAtegoryComponent } from './add-category.component';

describe('AddCAtegoryComponent', () => {
  let component: AddCAtegoryComponent;
  let fixture: ComponentFixture<AddCAtegoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AddCAtegoryComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddCAtegoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
