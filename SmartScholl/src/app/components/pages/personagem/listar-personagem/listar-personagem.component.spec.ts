import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarPersonagemComponent } from './listar-personagem.component';

describe('ListarPersonagemComponent', () => {
  let component: ListarPersonagemComponent;
  let fixture: ComponentFixture<ListarPersonagemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListarPersonagemComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListarPersonagemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
