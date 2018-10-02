import React, { Component } from 'react';
import { MuiThemeProvider } from '@material-ui/core/styles';
import HeaderApp from './components/Shared/Header/Header';
import Pallete from '../shared/MaterialTheme/MaterialTheme';
import Home from './components/Home/Home';
import { Route, Switch, BrowserRouter } from 'react-router-dom';

import '@styles/import.scss';
import {} from './app.scss';
import Recommendations from './components/Recommendations/Recommendations';

export class App extends Component {
  render() {
    return (
      <MuiThemeProvider theme={Pallete}>
        <HeaderApp />
        <main>
          <BrowserRouter>
            <Switch>
              <Route exact path="/" component={Home} />
              <Route
                exact
                path="/recommendations"
                component={Recommendations}
              />
            </Switch>
          </BrowserRouter>
        </main>
      </MuiThemeProvider>
    );
  }
}
