import axiosInstance from "./axiosInstance";

export const loginUser = async (email, password) => {
  return await axiosInstance.post("/auth/login", { email, password });
};

export const registerUser = async (userData) => {
  return await axiosInstance.post("/auth/register", userData);
};
