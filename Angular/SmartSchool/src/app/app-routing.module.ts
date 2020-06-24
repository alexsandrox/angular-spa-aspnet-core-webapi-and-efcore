import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { StudentsComponent } from './students/students.component';
import { TeachersComponent } from './teachers/teachers.component';
import { ProfileComponent } from './profile/profile.component';
import { DashboardComponent } from './dashboard/dashboard.component';


const routes: Routes = [
  { path: '', redirectTo: 'v1/dashboard', pathMatch: 'full' },
  { path: 'v1/dashboard', component: DashboardComponent },
  { path: 'v1/students', component: StudentsComponent },
  { path: 'v1/teachers', component: TeachersComponent },
  { path: 'v1/profile', component: ProfileComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
