import { Component, OnDestroy, OnInit } from '@angular/core';
import { BaseService } from '../base.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-jatekos',
  templateUrl: './jatekos.component.html',
  styleUrls: ['./jatekos.component.css']
})
export class JatekosComponent implements OnInit, OnDestroy{
  jatekosok:any
  feliratkozas = new Subscription()
  constructor(private base:BaseService){
  }

  ngOnInit(): void {
      this.feliratkozas= this.base.getJatekos().subscribe(
        (res)=>{
          this.jatekosok=res
          if (this.jatekosok){
            for (let i = 0; i < this.jatekosok.length; i++) {
              this.jatekosok[i].latszik=false;              
            }
          }
        }
      )
  }

  ngOnDestroy(): void {
      if (this.feliratkozas) this.feliratkozas.unsubscribe()
  }
}
