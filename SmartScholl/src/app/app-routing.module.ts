import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastrarNivelComponent } from './components/pages/nivel/cadastrar-nivel/cadastrar-nivel.component';
import { ListarNivelComponent } from './components/pages/nivel/listar-nivel/listar-nivel.component';
import { CadastrarPersonagemComponent } from './components/pages/personagem/cadastrar-personagem/cadastrar-personagem.component';
import { ListarPersonagemComponent } from './components/pages/personagem/listar-personagem/listar-personagem.component';
import { CadastrarUserComponent } from './components/pages/user/cadastrar-user/cadastrar-user.component';
import { ListarUserComponent } from './components/pages/user/listar-user/listar-user.component';

const routes: Routes = [
  {
    path: "pages/user/cadastrar",
    component: CadastrarUserComponent,
  },

  {
    path: "pages/user/cadastrar/:id",
    component: CadastrarUserComponent,
  },
  {
    path: "pages/user/listar",
    component: ListarUserComponent,
  },
  {
    path: "pages/nivel/cadastrar",
    component: CadastrarNivelComponent,
  },
  {
    path: "pages/nivel/listar",
    component: ListarNivelComponent,
  },
  {
    path: "pages/personagem/cadastrar",
    component: CadastrarPersonagemComponent,
  },
  {
    path: "pages/personagem/listar",
    component: ListarPersonagemComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
