import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastrarNivelComponent } from './cadastrar-nivel.component';

describe('CadastrarNivelComponent', () => {
  let component: CadastrarNivelComponent;
  let fixture: ComponentFixture<CadastrarNivelComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CadastrarNivelComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CadastrarNivelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
