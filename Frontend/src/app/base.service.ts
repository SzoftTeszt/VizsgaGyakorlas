import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BaseService {
  
  private url="http://172.16.16.136:5001/api/Jatekos/"
  private tippUrl="http://172.16.16.136:5001/api/Tipps/"
  private jatekosokSub = new BehaviorSubject(null)

  constructor(private http:HttpClient) { 
    this.loadJatekos()
  }

  private loadJatekos(){
      this.http.get(this.url).subscribe(
        (res:any)=>this.jatekosokSub.next(res)
      )
  }
  getJatekos(){
    return this.jatekosokSub
  }

  newTipp(tipp:any){
    this.http.post(this.tippUrl,tipp).forEach(
      ()=>this.loadJatekos()
    )
  }
  updateTipp(tipp:any){
    this.http.put(this.tippUrl+tipp.id,tipp).forEach(
      ()=>this.loadJatekos()
    )
  }

  deleteTipp(tipp:any){
    this.http.delete(this.tippUrl+tipp.id).forEach(
      ()=>this.loadJatekos()
    )
  }
  
}
