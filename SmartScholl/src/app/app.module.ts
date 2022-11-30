import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MatCardModule } from "@angular/material/card";
import { MatInputModule } from "@angular/material/input";
import { MatSelectModule } from "@angular/material/select";
import { MatButtonModule } from "@angular/material/button";
import { MatDatepickerModule } from "@angular/material/datepicker";
import { MatSlideToggleModule } from "@angular/material/slide-toggle";
import { MatSnackBarModule } from "@angular/material/snack-bar";
import { MatToolbarModule } from "@angular/material/toolbar";
import { MatIconModule } from "@angular/material/icon";
import { MatSidenavModule } from "@angular/material/sidenav";
import { MatListModule } from "@angular/material/list";
import { MatFormField, MatFormFieldModule } from "@angular/material/form-field";
import { CadastrarNivelComponent } from './components/pages/nivel/cadastrar-nivel/cadastrar-nivel.component';
import { ListarNivelComponent } from './components/pages/nivel/listar-nivel/listar-nivel.component';
import { CadastrarPersonagemComponent } from './components/pages/personagem/cadastrar-personagem/cadastrar-personagem.component';
import { ListarPersonagemComponent } from './components/pages/personagem/listar-personagem/listar-personagem.component';
import { CadastrarUserComponent } from './components/pages/user/cadastrar-user/cadastrar-user.component';
import { ListarUserComponent } from './components/pages/user/listar-user/listar-user.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    AppComponent,
    CadastrarNivelComponent,
    ListarNivelComponent,
    CadastrarPersonagemComponent,
    ListarPersonagemComponent,
    CadastrarUserComponent,
    ListarUserComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatCardModule,
    MatSelectModule,
    MatInputModule,
    MatButtonModule,
    MatDatepickerModule,
    MatSlideToggleModule,
    MatSnackBarModule,
    MatToolbarModule,
    MatIconModule,
    MatSidenavModule,
    MatListModule,
    MatFormFieldModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
