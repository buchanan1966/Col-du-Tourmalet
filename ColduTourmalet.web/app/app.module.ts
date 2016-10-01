import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { AppComponent } from './app.component'
import { HomeComponent } from './home.component';
import { Page1Component } from './page1.component';
import { Page2Component } from './page2.component';
import { JournalEntryDetailComponent } from './journalEntry.component';
import { EntryService } from './entry.service';

import { routing } from './app.routing';

@NgModule({
    imports: [
        BrowserModule,
        HttpModule,
        routing],
    declarations: [
        AppComponent,
        HomeComponent,
        Page1Component,
        Page2Component,
        JournalEntryDetailComponent],
    providers: [
        EntryService
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }

// These changes were required to get the example to run.
