import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-icon-card',
  templateUrl: './icon-card.component.html',
  styleUrls: ['./icon-card.component.scss']
})
export class IconCardComponent implements OnInit {
  @Input() title: string;
  @Input() redirectTo: string;
  @Input() src: string;

  constructor() { }

  ngOnInit(): void {
  }

}
