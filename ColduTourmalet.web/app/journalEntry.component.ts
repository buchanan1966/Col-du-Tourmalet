import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { Entry } from './entry';
import { EntryService } from './entry.service';

@Component({
    selector: 'journal-entry-detail',
    templateUrl: 'app/journal-entry-detail.html'
})
export class JournalEntryDetailComponent implements OnInit {
    @Input() entry: Entry;
    @Output() close = new EventEmitter();
    error: any;
    navigated = false; // true if navigated here

    constructor(
        private entryService: EntryService,
        private route: ActivatedRoute) {
    }

    ngOnInit(): void {

        this.route.params.forEach((params: Params) => {
            if (params['id'] !== undefined) {
                let id = +params['id'];
                this.navigated = true;
                this.entryService.getEntry(id)
                    .then(entry => {
                        console.log(entry)
                        this.entry = entry
                    });
            } else {
                this.navigated = false;
                this.entry = new Entry();
            }
        });
    }
}