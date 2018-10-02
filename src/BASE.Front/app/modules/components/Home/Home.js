import React from 'react';
import { Link } from 'react-router-dom';
import classes from './Home.scss';
import card from 'assets/images/Group.png';
import travel from 'assets/images/tickets.png';
import travelAdv from 'assets/images/tickets 2.png';
import AddIcon from '@material-ui/icons/Add';
import MapIcon from '@material-ui/icons/map';
import Button from '@material-ui/core/Button';

const Home = () => {
  return (
    <div>
      <div className={classes.sectionWrapper}>
        <div className={classes.titleWrapper}>
          <h2>Cards</h2>
          <AddIcon />
        </div>
        <div className={classes.cardsWrapper}>
          <img src={card} className="mr-2" />
          <img src={card} className="mr-2" />
          <img src={card} className="mr-2" />
        </div>
      </div>
      <div className={classes.sectionWrapper}>
        <div className={classes.titleWrapper}>
          <h2>Travels</h2>
        </div>
        <div className={classes.travelWrapper}>
          <Link to="/recommendations">
            <img src={travel} className="mb-2" />
          </Link>
          <Link to="/recommendations">
            <img src={travelAdv} className="mb-2" />
          </Link>
        </div>
      </div>
      <Button
        variant="fab"
        color="primary"
        aria-label="Map"
        className={classes.buttonMap}>
        <MapIcon />
      </Button>
    </div>
  );
};

export default Home;
