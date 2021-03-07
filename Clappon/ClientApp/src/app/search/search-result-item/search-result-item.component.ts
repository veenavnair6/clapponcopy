import { Component, Input, OnInit } from '@angular/core';
import { Device } from 'src/app/search/search.service';

@Component({
  selector: 'app-search-result-item',
  templateUrl: './search-result-item.component.html',
  styleUrls: ['./search-result-item.component.scss']
})
export class SearchResultItemComponent implements OnInit {
  @Input() option: Device;

  constructor() { }

  ngOnInit(): void {
  }

}
