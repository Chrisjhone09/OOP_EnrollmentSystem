import { Routes } from '@angular/router';
import { FormComponent } from './form/form.component';

export const routes: Routes = [
    {path: 'enroll', component: FormComponent},
    {path: '', redirectTo: 'enroll', pathMatch: 'full'}
];
