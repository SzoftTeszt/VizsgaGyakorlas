import { Component, Input } from '@angular/core';
import { BaseService } from '../base.service';

@Component({
  selector: 'app-tippek',
  templateUrl: './tippek.component.html',
  styleUrls: ['./tippek.component.css']
})
export class TippekComponent {
  @Input() jatekosId:any;
  @Input() tippek:any;

  newTipp:any={}
  oszlopok =["sz1","sz2","sz3","sz4","sz5","sz6"]
  constructor(private base:BaseService){}
  newTippek(){
    this.newTipp.jatekosId=this.jatekosId
    this.base.newTipp(this.newTipp)
  }
  updateTipp(tipp:any){
    this.base.updateTipp(tipp)
  }
  deleteTipp(tipp:any){
    this.base.deleteTipp(tipp)
  }

}
