import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Nivel } from 'src/app/models/nivel';

@Component({
  selector: 'app-listar-nivel',
  templateUrl: './listar-nivel.component.html',
  styleUrls: ['./listar-nivel.component.css']
})
export class ListarNivelComponent implements OnInit{
  niveis!: Nivel[];
  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    //Configuração da requisição
    this.http
      .get<Nivel[]>("https://localhost:5001/api/nivel/listar")
      // Execução da requisição
      .subscribe({
        next: (niveis) => {
          this.niveis = niveis;
        },
      });
  }
}
