import { Nivel } from "./nivel";
import { User } from "./user";

export interface Personagem {
    id?: number;
    nome: string;
    dano: number;
    nivel: Nivel;
    user: User;
}