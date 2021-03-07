import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Device, SearchService } from './search.service';
import { debounceTime, filter, map, switchMap } from 'rxjs/operators'
import { Observable } from 'rxjs';
import { Router } from '@angular/router';

export const DEBOUNCE_TIME = 1000;
export const SEARCH_CHAR_LIMIT = 1;

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.scss']
})
export class SearchComponent implements OnInit {
  searchCtrl = new FormControl();
  options$: Observable<Device[]>;

  constructor(private searchService: SearchService,
    private router: Router) { }

  performSearch(): Observable<Device[]> {
    return this.searchService.search(this.searchCtrl?.value);
  }

  ngOnInit(): void {
    this.options$ = this.searchCtrl.valueChanges
      .pipe(
        filter((text: string) => text.length > SEARCH_CHAR_LIMIT),
        debounceTime(DEBOUNCE_TIME),
        switchMap(() => this.performSearch())
      );
  }

  navigateToRepair(): void {
    this.router.navigateByUrl('/repair');
  }
}
