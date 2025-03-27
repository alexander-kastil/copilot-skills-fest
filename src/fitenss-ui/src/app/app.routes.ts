import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { StudentsComponent } from './students/students.component';
import { ExercisesComponent } from './exercises/exercises.component';

export const routes: Routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', component: HomeComponent },
    { path: 'students', component: StudentsComponent },
    { path: 'exercises', component: ExercisesComponent },
    { path: '**', redirectTo: 'home' }
];
