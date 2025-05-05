import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Student } from '../models/student';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  
  apiUrl = "https://localhost:7257/api/enroll";
  constructor(private http: HttpClient) { }

  submitEnrollmentForm(form : Student):Observable<any>{
    return this.http.post(this.apiUrl + "/submit", form)
  }
  
  getEnrollmentSettingStatus():Observable<any> {
    return this.http.get(this.apiUrl)
  }

}
