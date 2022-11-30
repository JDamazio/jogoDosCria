import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarNivelComponent } from './listar-nivel.component';

describe('ListarNivelComponent', () => {
  let component: ListarNivelComponent;
  let fixture: ComponentFixture<ListarNivelComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListarNivelComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListarNivelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
