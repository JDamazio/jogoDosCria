import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from 'src/app/models/user';
@Component({
  selector: 'app-listar-user',
  templateUrl: './listar-user.component.html',
  styleUrls: ['./listar-user.component.css']
})
export class ListarUserComponent implements OnInit{
  users!: User[];
  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.http
      .get<User[]>("https://localhost:5001/api/nivel/listar")
      .subscribe({
        next: (users) => {
          this.users = users;
        },
      });
  }

  deletar(id: number): void{
    this.http.delete<User>
      (`https://localhost:5001/api/user/deletar/${id}`)
      .subscribe({
        next: (user) => {
          this.ngOnInit();
        },
      });
  }
}
