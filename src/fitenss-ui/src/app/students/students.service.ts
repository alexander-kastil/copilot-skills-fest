import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, tap } from 'rxjs';
import { Student } from '../models/student.model';
import { environment } from '../../environments/environment';

@Injectable({
    providedIn: 'root'
})
export class StudentsService {
    private http = inject(HttpClient);
    private apiUrl = environment.apiUrl;

    getStudents(): Observable<Student[]> {
        return this.http.get<Student[]>(`${this.apiUrl}Students`).pipe(tap(students => { console.log(students) }));
    }

    getStudent(id: number): Observable<Student> {
        return this.http.get<Student>(`${this.apiUrl}Students/${id}`);
    }
}