import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Personagem } from 'src/app/models/personagem';

@Component({
  selector: 'app-listar-personagem',
  templateUrl: './listar-personagem.component.html',
  styleUrls: ['./listar-personagem.component.css']
})
export class ListarPersonagemComponent implements OnInit{
  personagens!: Personagem[];
  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.http
      .get<Personagem[]>("https://localhost:5001/api/personagem/listar")
      .subscribe({
        next: (personagens) => {
          this.personagens = personagens;
        },
      });
  }
}
