import { Component, inject, signal, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentsService } from './students.service';
import { Student } from '../models/student.model';
import { catchError, finalize, of } from 'rxjs';

@Component({
  selector: 'app-students',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.scss']
})
export class StudentsComponent implements OnInit {
  private studentsService = inject(StudentsService);

  students = signal<Student[]>([]);
  loading = signal<boolean>(true);
  error = signal<string | null>(null);

  ngOnInit(): void {
    this.loadStudents();
  }

  loadStudents(): void {
    console.log('Loading students...');
    this.studentsService.getStudents()
      .pipe(
        finalize(() => this.loading.set(false)),
        catchError(err => {
          console.error('Error loading students:', err);
          this.error.set('Failed to load students. Please try again later.');
          return of([]);
        })
      )
      .subscribe({
        next: (data) => {
          console.log('Students data received:', data);
          this.students.set(data || []);
        },
        error: (err) => {
          console.error('Error in subscription:', err);
        }
      });
  }

  getAge(dateOfBirth: string): number {
    const today = new Date();
    const birthDate = new Date(dateOfBirth);
    let age = today.getFullYear() - birthDate.getFullYear();
    const monthDiff = today.getMonth() - birthDate.getMonth();

    if (monthDiff < 0 || (monthDiff === 0 && today.getDate() < birthDate.getDate())) {
      age--;
    }

    return age;
  }
}
