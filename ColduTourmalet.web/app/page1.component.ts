import { Component, OnInit } from '@angular/core';
import { Entry } from './entry';
import { EntryService } from './entry.service';

@Component({
    selector: 'page1',
    templateUrl: 'app/page1.html'
})
export class Page1Component implements OnInit {
    entries: Entry[] = [];

    constructor(
//        private router: Router,
        private entryService: EntryService) {
    }

    ngOnInit(): void {
        this.entryService.getEntries()
            .then(entries => {
                console.log(entries)
                this.entries = entries
            });
    }
}
