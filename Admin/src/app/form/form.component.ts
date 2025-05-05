import { CommonModule } from '@angular/common';
import { Component, NgModule, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms'; 
import { DataService } from '../services/data.service';
import { Student } from '../models/student';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavigationComponent } from '../nav/navigation/navigation.component';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { SuccessDialogComponent } from '../success-dialog/success-dialog.component';
@Component({
  selector: 'app-form',
  imports: [CommonModule, FormsModule,  
    MatDatepickerModule,
    MatNativeDateModule,
    MatInputModule,
    MatFormFieldModule,
    FormsModule, NavigationComponent],
  templateUrl: './form.component.html',
  styleUrl: './form.component.css'
})
export class FormComponent implements OnInit{
  showValidation = true;
  emailNullValidation = false;
  showNotice : boolean = false
  enrollmentSetting : EnrollmentSetting | undefined

  form = new Student();
  constructor(private data: DataService, private mat : MatDialog) {}
  ngOnInit(): void {
    this.data.getEnrollmentSettingStatus().subscribe(
      response => {
        this.enrollmentSetting = response
      }
    )
  }

  hideValidation(){
    this.showValidation = false;
  }

  submit() {
    

    if(this.form.email === null || this.form.email == ''){
      this.emailNullValidation = !this.emailNullValidation;
      return;
    }


      this.data.submitEnrollmentForm(this.form).subscribe({
        next: (response) => {
          console.log("Form submitted successfully", response);
          
        },
        error: (error) => {
          console.log("Error submitting form", error);
        }
      });
    
  }
  
}
interface EnrollmentSetting {
  allowRequest : boolean
  limit : number
}
