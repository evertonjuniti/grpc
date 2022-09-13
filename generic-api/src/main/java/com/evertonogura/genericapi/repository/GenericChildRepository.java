package com.evertonogura.genericapi.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import com.evertonogura.genericapi.entity.GenericChildEntity;

public interface GenericChildRepository extends JpaRepository<GenericChildEntity, Long> {

}
