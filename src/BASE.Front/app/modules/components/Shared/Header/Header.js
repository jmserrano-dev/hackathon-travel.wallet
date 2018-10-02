import React from 'react';
import AppBar from '@material-ui/core/AppBar';
import Toolbar from '@material-ui/core/Toolbar';
import Typography from '@material-ui/core/Typography';
import Badge from '@material-ui/core/Badge';
import IconButton from '@material-ui/core/IconButton';
import MenuIcon from '@material-ui/icons/Menu';
import NotificationsIcon from '@material-ui/icons/Notifications';

import classes from './Header.scss';

const HeaderApp = () => {
  return (
    <AppBar position="static">
      <Toolbar className={classes.toolBarWrapper}>
        <IconButton
          className={classes.menuButton}
          color="inherit"
          aria-label="Menu">
          <MenuIcon />
        </IconButton>
        <Typography variant="title" color="inherit" className={classes.grow}>
          TravelWallet
        </Typography>
        <IconButton color="inherit">
          <Badge className={classes.margin} badgeContent={5} color="secondary">
            <NotificationsIcon />
          </Badge>
        </IconButton>
      </Toolbar>
    </AppBar>
  );
};

export default HeaderApp;
