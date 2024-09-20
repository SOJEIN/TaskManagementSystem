import React from "react";
import {
  AppBar,
  Toolbar,
  Typography,
  Button,
  Container,
  Grid,
} from "@mui/material";
import { useNavigate } from "react-router-dom";

const Dashboard = () => {
  const navigate = useNavigate();

  const handleLogout = () => {
    localStorage.removeItem("token");
    navigate("/login");
  };

  return (
    <div>
      <AppBar position="static">
        <Toolbar>
          <Typography variant="h6" style={{ flexGrow: 1 }}>
            Dashboard
          </Typography>
          <Button color="inherit" onClick={handleLogout}>
            Logout
          </Button>
        </Toolbar>
      </AppBar>

      <Container>
        <Typography variant="h4" component="h1" gutterBottom>
          Bienvenido al Dashboard
        </Typography>

        <Grid container spacing={3}>
          <Grid item xs={12} md={4}>
            <Typography variant="h6">Tareas Pendientes: 5</Typography>
          </Grid>
          <Grid item xs={12} md={4}>
            <Typography variant="h6">Tareas en Proceso: 2</Typography>
          </Grid>
          <Grid item xs={12} md={4}>
            <Typography variant="h6">Tareas Completadas: 10</Typography>
          </Grid>
        </Grid>
      </Container>
    </div>
  );
};

export default Dashboard;
