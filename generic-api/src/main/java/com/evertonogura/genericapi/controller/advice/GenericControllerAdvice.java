package com.evertonogura.genericapi.controller.advice;

import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.ControllerAdvice;
import org.springframework.web.bind.annotation.ExceptionHandler;
import org.springframework.web.servlet.mvc.method.annotation.ResponseEntityExceptionHandler;

import com.evertonogura.genericapi.exception.GenericNotFoundException;
import com.evertonogura.genericapi.model.ErrorModel;

@ControllerAdvice
public class GenericControllerAdvice extends ResponseEntityExceptionHandler {
	
	@ExceptionHandler(GenericNotFoundException.class)
	public ResponseEntity<ErrorModel> GenericNotFoundHandler(GenericNotFoundException ex) {
		return ResponseEntity.status(HttpStatus.NOT_FOUND).body(new ErrorModel(ex.getMessage()));
	}
	
}