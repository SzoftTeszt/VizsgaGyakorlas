import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JatekosComponent } from './jatekos.component';

describe('JatekosComponent', () => {
  let component: JatekosComponent;
  let fixture: ComponentFixture<JatekosComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [JatekosComponent]
    });
    fixture = TestBed.createComponent(JatekosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
